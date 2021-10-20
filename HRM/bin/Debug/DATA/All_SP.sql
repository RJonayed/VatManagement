USE [ROFASHA]
GO
/****** Object:  StoredProcedure [dbo].[DBase_backup]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
























/****** Object:  Stored Procedure dbo.DBase_backup    Script Date: 09/05/2002 2:52:46:PM ******/

CREATE PROCEDURE [dbo].[DBase_backup]

@D_BaseMedia Varchar(100),
@D_BasePath varchar(300),
@D_BaseNAme varchar(30)
  AS
/*set  @D_BaseMedia = "TRYBAK"
set @D_BasePath = "c:\trybak12.bak"
set @D_BaseNAme ="PAyrollEPZ"*/
execute SP_Addumpdevice "Disk", @D_BaseMedia,@D_BasePath
backup Database @D_BaseName to @D_BaseMedia
execute SP_DropDevice @D_BaseMedia
























GO
/****** Object:  StoredProcedure [dbo].[SpAdvProcess]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO














CREATE PROCEDURE [dbo].[SpAdvProcess]
	@FormonthNo int
	,@ForYear int
as

	--declare variable part start 
declare @EmpAutoNo money,@EmpId varchar(20),@ComId varchar(10),@AdvCode varchar(100),@Balance money,@instAmt money,@PayDate datetime

delete from advancedetails where month(paydate)=@forMonthNo and year(paydate)=@foryear and manual=0
               
set @PayDate=convert(datetime,'01/' + convert(varchar,@formonthno) + '/' + convert(varchar,@forYear) ,103)


	Declare curSalary Cursor
	Forward_Only
	Keyset
	Scroll_locks
	For
   	------- select qry the main qry-------
select empAutoNo,AdvanceCode,Balance,InstAmt,comid,empid from VwAdv where balance>0 and 
empAutoNo not in (select empAutoNo from advanceDetails where month(paydate)=@forMonthNo and year(payDate)=@forYear and manual=1)
	Open curSalary-----Loop strat

	Fetch Next from curSalary into @empAutoNo,@AdvCode,@Balance,@instAmt,@comId,@empid
	while @@Fetch_Status=0
	
	Begin

--set @PayDate=convert(datetime,'01/' + convert(varchar,@formonthno) + '/' + convert(varchar,@forYear),103)

if isnull(@instAmt,0)>isnull(@balance,0)
begin
set @instAmt=isnull(@balance,0)
end

             


	insert into advanceDetails (empAutoNo,AdvanceCode,PayDate,PaidAmount,comid,empid,paytype) 
                                       values (@EmpAutoNo,@advcode,convert(datetime,@payDate,103),@instAmt,@comid,@empid,'Salary')
                
               
	Fetch Next from curSalary into @empAutoNo,@AdvCode,@Balance,@instAmt,@comid,@empid

if @@Error <> 0
		Begin
		Rollback Transaction
		Raiserror('Insertion Failed',16,1)
		Return -1
		End	
	End
Deallocate cursalary-----loop end














GO
/****** Object:  StoredProcedure [dbo].[SpAutoVrFromCashSale]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[SpAutoVrFromCashSale] @SalesAutoNO int
as

declare @pcname varchar(100),@vdate datetime,@usercode varchar(100),@voucherNo varchar(50),@AutoRmk varchar(100),@comid varchar(20)
,@alreadyExist int,@headId int,@Amount money,@vType varchar(50),@autoNoFromVrMstr int,@invNo varchar(20),@payMode varchar(100)
,@note varchar(100)

set @vtype= 'Cash Sale'
--exec SpAutoVrFromCashSale 118
--select * from salemstr 
set @alreadyExist=0

set @AutoRmk='Auto vr from cash sale ' + convert(varchar,@SalesAutoNO)

select @alreadyExist = count(voucherno) from vouchermstr where autormk=@AutoRmk group by autono

--select @autoNoFromVrMstr
--delete from vouchermstr where autormk=@AutoRmk

select @pcname=pcname,@vdate=saledate,@usercode=usercode,@comid=comid,@Amount=payable,
@invNo=invoiceno,@payMode=paymode from salemstr where autono=@SalesAutoNO
--select * From vouchermstr


select @headId=headid from head where headname='cash sale'

set @note='Invoice NO: ' +  @invNo  


if @alreadyExist=0
begin

	select @voucherNo=max(CONVERT(INT,voucherno))+1 from vouchermstr

	insert into vouchermstr(pcname,vdate,usercode,voucherNo,AutoRmk,comid,vrType)
	values (@pcname,convert(datetime,@vdate,103),@usercode,@voucherNo,@AutoRmk,@comid,@vtype)


	select @autoNoFromVrMstr=autoNO from vouchermstr where autormk=@AutoRmk

	insert into voucher(voucherno,vdate,headid,cr,vtype,slno,comid,amount,d_c,autoRmk,pcname,autoNoFromMstrTbl,usercode,noteRmk,note)
	values (@voucherNO,convert(datetime,@vdate,103),@headId,@Amount,@vtype,1,@comid,@amount,'Cr',@autoRmk,@pcname,@autoNoFromVrMstr
	,@usercode,@note,@note) 


	select @headid =headid from head where rmk =@paymode

	if @paymode like '%card'
	begin
	select @headid =headid from head where rmk='card account'
	end
	--select * from head

	insert into voucher(voucherno,vdate,headid,dr,vtype,slno,comid,amount,d_c,autoRmk,pcname,autoNoFromMstrTbl,usercode,noteRmk,note)
	values (@voucherNO,convert(datetime,@vdate,103),@headId,@Amount,@vtype,2,@comid,@amount,'Dr',@autoRmk,@pcname,@autoNoFromVrMstr
	,@usercode,@note,@note ) 
end



if @alreadyExist>0
begin
	select @voucherNo=voucherno from vouchermstr where autormk=@AutoRmk
	
	delete from voucher where autormk=@AutoRmk
	delete from vouchermstr where autormk=@AutoRmk
	

	insert into vouchermstr(pcname,vdate,usercode,voucherNo,AutoRmk,comid,vrType)
	values (@pcname,@vdate,@usercode,@voucherNo,@AutoRmk,@comid,@vtype)

	
	select @autoNoFromVrMstr=autoNO from vouchermstr where autormk=@AutoRmk

	insert into voucher(voucherno,vdate,headid,cr,vtype,slno,comid,amount,d_c,autoRmk,pcname,autoNoFromMstrTbl,usercode,noteRmk,note)
	values (@voucherNO,convert(datetime,@vdate,103),@headId,@Amount,@vtype,1,@comid,@amount,'Cr',@autoRmk,@pcname,@autoNoFromVrMstr
	,@usercode,@note,@note) 

	select @headid =headid from head where rmk =@paymode

	if @paymode like '%card'
	begin
	select @headid =headid from head where rmk='card account'
	end

	insert into voucher(voucherno,vdate,headid,dr,vtype,slno,comid,amount,d_c,autoRmk,pcname,autoNoFromMstrTbl,usercode,noteRmk,note)
	values (@voucherNO,convert(datetime,@vdate,103),@headId,@Amount,@vtype,2,@comid,@amount,'Dr',@autoRmk,@pcname,@autoNoFromVrMstr
	,@usercode,@note,@note) 
end

--exec SpAutoVrFromCashSale 118
--select * from voucher
--select * from head where headid=17
--select * from salemstr
--select @AutoRmk

select * from item where barcode='1001'








GO
/****** Object:  StoredProcedure [dbo].[SpAutoVrFromCollection]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





--select * from billcollection
--delete from billcollection
CREATE Procedure [dbo].[SpAutoVrFromCollection] @colId varchar(20)
as

--exec SpAutoVrFromCollection ''


declare @pcname varchar(100),@vdate datetime,@usercode varchar(100),@voucherNo varchar(50),@AutoRmk varchar(100),@comid varchar(20)
,@alreadyExist int,@headId int,@Amount money,@vType varchar(50),@autoNoFromVrMstr int,@invNo varchar(20),@payMode varchar(100)
,@note varchar(100),@partyAutoNo int,@paidAmount money,@userName varchar(20),@acctHead varchar(50)



select @vdate=coldate,@partyAutoNo=partyAutoNo,@Amount=amount,@pcname=pcname,@username=userid,@note=rmk from billCollection
 where colid=@colid


set @vtype= 'Credit'

set @AutoRmk='Auto vr from bill collection no ' + @colId

delete from voucher where autormk=@autormk
delete from voucherMstr where autormk=@autormk


select @headId=headid from head where headname='Monthly Bill'

--set @note='For the month of ' + @formonth + ' ' + @foryear

	select @voucherNo=isnull(max(CONVERT(INT,voucherno)),1000)+1 from vouchermstr

	insert into vouchermstr(pcname,vdate,usercode,voucherNo,AutoRmk,comid,vrType)
	values ('Auto',convert(datetime,@vdate,103),'',@voucherNo,@AutoRmk,'1',@vtype)


	select @autoNoFromVrMstr=autoNo from vouchermstr where autormk=@AutoRmk
	
--select * from partyinfo

select @headId=headid from head where headname= (select accthead from partyinfo where autono=@partyAutoNo)

insert into voucher(voucherno,vdate,headid,cr,vtype,slno,comid,amount,d_c,autoRmk,pcname,autoNoFromMstrTbl,usercode,noteRmk,note)
values( @voucherNo,convert(datetime,@vdate,103),@headid,@amount,@vtype,1,'1',@amount,'Cr',@autoRmk,
'Auto',@autoNoFromVrMstr,'',@note,@note )

select @headId=headid from head where headname in ('cash','cash in hand')
select @accthead=accthead from partyinfo where autono=@partyautono

insert into voucher(voucherno,vdate,headid,dr,vtype,slno,comid,amount,d_c,autoRmk,pcname,autoNoFromMstrTbl,usercode,noteRmk,note)
values( @voucherNo,convert(datetime,@vdate,103),@headid,@amount,@vtype,2,'1',@amount,'Dr',@autoRmk,
'Auto',@autoNoFromVrMstr,'',@note,'Collected From ' + @accthead )

--exec SpAutoVrFromCollection ''
--select * from voucher where autormk='Auto vr from monthly bill January 2019'






GO
/****** Object:  StoredProcedure [dbo].[SpAutoVrFromCreditSale]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE   procedure [dbo].[SpAutoVrFromCreditSale] @SalesAutoNo int
as

declare @pcname varchar(100),@vdate datetime,@usercode varchar(100),@voucherNo varchar(50),@AutoRmk varchar(100),@comid varchar(20)
,@alreadyExist int,@headId int,@Amount money,@vType varchar(50),@autoNoFromVrMstr int,@invNo varchar(20),@payMode varchar(100)
,@note varchar(100),@partyAutoNo int,@paidAmount money

set @vtype= 'Sales'
--exec SpAutoVrFromCreditSale 373
--select * from salemstr 
set @alreadyExist=0

set @AutoRmk='Auto vr from credit sale ' + convert(varchar,@SalesAutoNo)
--set @AutoRmk as AutoRmk

select @alreadyExist = count(voucherno) from vouchermstr where autormk=@AutoRmk group by autono
--select @alreadyExist as Exist

--select @autoNoFromVrMstr
--delete from vouchermstr where autormk=@AutoRmk

select @pcname=pcname,@vdate=saledate,@usercode=usercode,@comid=comid,@Amount=payable,
@invNo=invoiceno,@payMode=paymode,@partyAutoNo=partyauto,@paidAmount=paid from salemstr where autono=@SalesAutoNo
--select * From vouchermstr
--select * from salemstr

--select * from partyinfo

select @headId=headid from head where headname='Sales'
--select @headId as SalesHeadID

set @note='Invoice NO: ' +  @invNo  


if @alreadyExist=0
begin

	select @voucherNo=max(CONVERT(INT,voucherno))+1 from vouchermstr

	insert into vouchermstr(pcname,vdate,usercode,voucherNo,AutoRmk,comid,vrType)
	values (@pcname,convert(datetime,@vdate,103),@usercode,@voucherNo,@AutoRmk,@comid,@vtype)


	select @autoNoFromVrMstr=autoNo from vouchermstr where autormk=@AutoRmk
	

	insert into voucher(voucherno,vdate,headid,cr,vtype,slno,comid,amount,d_c,autoRmk,pcname,autoNoFromMstrTbl,usercode,noteRmk,note)
	values (@voucherNO,convert(datetime,@vdate,103),@headId,@Amount,@vtype,1,@comid,@amount,'Cr',@autoRmk,@pcname,@autoNoFromVrMstr
	,@usercode,@note,@note) 


	
	select @headid =headid from head where headname in (select accthead from partyinfo where autono=@partyAutoNo)
	--select * from head where rmk='card account'

	--select * from head

	insert into voucher(voucherno,vdate,headid,dr,vtype,slno,comid,amount,d_c,autoRmk,pcname,autoNoFromMstrTbl,usercode,noteRmk,note)
	values (@voucherNO,convert(datetime,@vdate,103),@headId,@Amount,@vtype,2,@comid,@amount,'Dr',@autoRmk,@pcname,@autoNoFromVrMstr
	,@usercode,@note,@note ) 


Select * from SaleMstr



--paid 
if @paidAmount>0 
begin
	select @headid =headid from head where headname in ('cash in hand','cash')

	insert into voucher(voucherno,vdate,headid,dr,vtype,slno,comid,amount,d_c,autoRmk,pcname,autoNoFromMstrTbl,usercode,noteRmk,note)
	values (@voucherNO,convert(datetime,@vdate,103),@headId,@paidAmount,@vtype,2,@comid,@amount,'Dr',@autoRmk,@pcname,@autoNoFromVrMstr
	,@usercode,@note,@note )


select @headid =headid from head where headname in (select accthead from partyinfo where autono=@partyAutoNo)

	insert into voucher(voucherno,vdate,headid,cr,vtype,slno,comid,amount,d_c,autoRmk,pcname,autoNoFromMstrTbl,usercode,noteRmk,note)
	values (@voucherNO,convert(datetime,@vdate,103),@headId,@paidAmount,@vtype,1,@comid,@amount,'Cr',@autoRmk,@pcname,@autoNoFromVrMstr
	,@usercode,@note,@note) 


end	
	
	--select * from head where rmk='card account'

	--select * from head


end



if @alreadyExist>0
begin
	select @voucherNo=voucherno from vouchermstr where autormk=@AutoRmk
	
	delete from voucher where autormk=@AutoRmk
	delete from vouchermstr where autormk=@AutoRmk

Select * from VoucherMstr Order By AutoNo DESC
Select * from Voucher Order By AutoNo DESC
Select * from SaleMstr where InvoiceNO = 1033
	

	insert into vouchermstr(pcname,vdate,usercode,voucherNo,AutoRmk,comid,vrType)
	values (@pcname,@vdate,@usercode,@voucherNo,@AutoRmk,@comid,@vtype)

	
	select @autoNoFromVrMstr=autoNO from vouchermstr where autormk=@AutoRmk
	select @headId=headid from head where headname='Sales'


	insert into voucher(voucherno,vdate,headid,cr,vtype,slno,comid,amount,d_c,autoRmk,pcname,autoNoFromMstrTbl,usercode,noteRmk,note)
	values (@voucherNO,convert(datetime,@vdate,103),@headId,@Amount,@vtype,1,@comid,@amount,'Cr',@autoRmk,@pcname,@autoNoFromVrMstr
	,@usercode,@note,@note) 

	select @headid =headid from head,Partyinfo,SaleMstr where Head.HeadName=Partyinfo.AcctHead 
	and SaleMstr.PartyAuto=Partyinfo.AutoNo and SaleMstr.AutoNo=@SalesAutoNo

	if @paymode like '%card'
	begin
	select @headid =headid from head where rmk='card account'
	end

	insert into voucher(voucherno,vdate,headid,dr,vtype,slno,comid,amount,d_c,autoRmk,pcname,autoNoFromMstrTbl,usercode,noteRmk,note)
	values (@voucherNO,convert(datetime,@vdate,103),@headId,@Amount,@vtype,2,@comid,@amount,'Dr',@autoRmk,@pcname,@autoNoFromVrMstr
	,@usercode,@note,@note) 


	select @headid =headid from head,Partyinfo,SaleMstr where Head.HeadName=Partyinfo.AcctHead 
	and SaleMstr.PartyAuto=Partyinfo.AutoNo and SaleMstr.AutoNo=@SalesAutoNo


	select @amount=paid from SaleMstr where AutoNo=@SalesAutoNo

	insert into voucher(voucherno,vdate,headid,cr,vtype,slno,comid,amount,d_c,autoRmk,pcname,autoNoFromMstrTbl,usercode,noteRmk,note)
	values (@voucherNO,convert(datetime,@vdate,103),@headId,@Amount,@vtype,1,@comid,@amount,'Cr',@autoRmk,@pcname,@autoNoFromVrMstr
	,@usercode,@note,@note) 


	select @headId=headid from head where headname='Cash In Hand'

	select @amount=paid from SaleMstr where AutoNo=@SalesAutoNo


	insert into voucher(voucherno,vdate,headid,dr,vtype,slno,comid,amount,d_c,autoRmk,pcname,autoNoFromMstrTbl,usercode,noteRmk,note)
	values (@voucherNO,convert(datetime,@vdate,103),@headId,@Amount,@vtype,2,@comid,@amount,'Dr',@autoRmk,@pcname,@autoNoFromVrMstr
	,@usercode,@note,@note)



end

--exec SpAutoVrFromCashSale 118
--select * from voucher
--select * from head where headid=17
--select * from salemstr
--select @AutoRmk







GO
/****** Object:  StoredProcedure [dbo].[SpAutoVrFromMonthlyBill]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






CREATE Procedure [dbo].[SpAutoVrFromMonthlyBill] @ForMonth varchar(20), @ForYear varchar(20)
as

--exec SpAutoVrFromMonthlyBill 'January', '2019'



declare @pcname varchar(100),@vdate datetime,@usercode varchar(100),@voucherNo varchar(50),@AutoRmk varchar(100),@comid varchar(20)
,@alreadyExist int,@headId int,@Amount money,@vType varchar(50),@autoNoFromVrMstr int,@invNo varchar(20),@payMode varchar(100)
,@note varchar(100),@partyAutoNo int,@paidAmount money



select @vdate=fdate from monthlysetup where formonth=@formonth and foryear=@foryear

set @vdate=isnull(@vdate,convert(datetime,convert(varchar,getdate(),103),103))

set @vtype= 'Journal'

set @AutoRmk='Auto vr from monthly bill ' + @formonth + ' ' + @foryear

delete from voucher where autormk=@autormk
delete from voucherMstr where autormk=@autormk

select @alreadyExist = count(voucherno) from vouchermstr where autormk=@AutoRmk group by autono

select @headId=headid from head where headname='Monthly Bill'

set @note='For the month of ' + @formonth + ' ' + @foryear

	select @voucherNo=isnull(max(CONVERT(INT,voucherno)),1000)+1 from vouchermstr

	insert into vouchermstr(pcname,vdate,usercode,voucherNo,AutoRmk,comid,vrType)
	values ('Auto',convert(datetime,@vdate,103),'',@voucherNo,@AutoRmk,'1',@vtype)


	select @autoNoFromVrMstr=autoNo from vouchermstr where autormk=@AutoRmk
	
--select * from partyinfo

	insert voucher(voucherno,vdate,headid,dr,vtype,slno,comid,amount,d_c,autoRmk,pcname,autoNoFromMstrTbl,usercode,noteRmk,note)
select @voucherNo,convert(datetime,@vdate,103),h.headid,p.contractMoney,@vtype,1,'1',p.contractMoney,'Dr',@autoRmk,
'Auto',@autoNoFromVrMstr,'',@note,@note from partyinfo p,head h where h.headname=p.acctHead and 
contractMoney>0 and sts=1 and actfrom<=convert(datetime,@vdate,103)
	

	insert voucher(voucherno,vdate,headid,cr,vtype,slno,comid,amount,d_c,autoRmk,pcname,autoNoFromMstrTbl,usercode,noteRmk,note)
select @voucherNo,convert(datetime,@vdate,103),@headid,isnull(sum(p.contractMoney),0),@vtype,1,'1',isnull(sum(p.contractMoney),0)
,'Cr',@autoRmk,
'Auto',@autoNoFromVrMstr,'',@note,@note from partyinfo p,head h 
where h.headname=p.acctHead and contractMoney>0 and sts=1 and actfrom<=convert(datetime,@vdate,103) 



--exec SpAutoVrFromMonthlyBill 'January', '2019'
--select * from voucher where autormk='Auto vr from monthly bill January 2019'






GO
/****** Object:  StoredProcedure [dbo].[SpAutoVrFromPurchase]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO













CREATE PROCEDURE [dbo].[SpAutoVrFromPurchase] @PurchaseAutoNo numeric,@ComId varchar(10),@userCode varchar(100) ,@pcName varchar(100),@CashAmt money

as

declare @vNo varchar(100),@partyName varchar(100),@PartyCode varchar(100),@acctHead varchar(200),@existOrNot int,@source varchar(100),@headId money
,@opBal money,@OpBalDate varchar(100),@autoRmk varchar(200),@drHeadId int,@crHeadId int,@drCr varchar(10),@purchaseCode varchar(20)
,@autoNoFromVrMstr money,@partyAutoNo int,@PurDate datetime,@note varchar(200),@TotAmt money,@crHeadNameFromPurchase varchar(100)


set @autoRmk='Auto Vr from Purchase Auto No ' + convert(varchar,@PurchaseAutoNo)

delete from voucher where autonoFrommstrTbl in (select autono from voucherMstr where autormk=@autormk)
delete from voucherMstr where autormk=@autormk

select @partyAutoNo=partyAutoNo,@PurDate=PurchaseDate,@purchaseCode=purchaseCode,@TotAmt=totalPrice,@crHeadNameFromPurchase=crHead
 from purchaseMstr where autono=@PurchaseAutoNo

select @acctHead=acctHead, @source='Party - ' + convert(varchar,@partyAutoNo),@opBal=opbal,@opBalDate=convert(datetime,opbaldate,103)
,@drCr=drCr,@partyName=PartyName from partyInfo where autono=@partyAutoNo


	set @existOrNot=0
	select @existOrNot=count(voucherno) from voucherMstr where autoRmk=@autoRmk


-- if  cash purchase
			if @acctHead like 'purchase' or @acctHead like 'cash purchase'
			begin
			select @drHeadid=headid from head where comid=@comid and HeadName like 'cash purchase%' order by headname
--			select @crHeadid =headid from head where headname in ('Cash','Cash in hand','petty cash') and comid=@comid
			select @crHeadid =headid from head where headname =@crHeadNameFromPurchase and comid=@comid
			set @note='Cash Purchase with Purchase Code: ' + convert(varchar,@purchaseCode) 
				if @existOrNot=0
				begin
				select @vno=isnull(max(convert(int,voucherno)),0)+1 from voucherMstr where isnumeric(voucherno)=1

				delete from voucherMstr where autoRmk=@autoRmk and comid=@comid
				delete from voucher where autoRmk=@autoRmk and comid=@comid
		
				insert vouchermstr(voucherno,vdate,comid,usercode,pcname,autormk) values (@vno,convert(datetime,@PurDate,103),@comid,@usercode,@pcname,@AutoRmk)
				select @autoNoFromVrMstr=autoNo from vouchermstr where autormk=@AutoRmk

				insert into voucher (autoNoFromMstrTbl,voucherno,headid,dr,note,autormk,pcname,usercode,d_c,comid,vtype) values (@autoNoFromVrMstr,@vno,@Drheadid,@CashAmt,@note ,@AutoRmk,@pcname,@usercode,'Dr',@comid,'Expense')
				insert into voucher (autoNoFromMstrTbl,voucherno,headid,cr,note,autormk,pcname,usercode,d_c,comid,vtype) values (@autoNoFromVrMstr,@vno,@Crheadid,@CashAmt,@note,@AutoRmk,@pcname,@usercode,'Cr',@comid,'Expense')
				end	





				if @existOrNot=1
				begin
		--		select @vno=voucherno from voucherMstr where isnumeric(voucherno)=1

				update vouchermstr set vdate=convert(datetime,@PurDate,103),usercode=@usercode,pcname=@pcname where autormk=@AutoRmk and comid=@comid

				update voucher set dr=@CashAmt,pcname=@pcname,usercode=@userCode where d_c='dr' and autormk=@AutoRmk and comid=@comid
				update voucher set cr=@CashAmt,pcname=@pcname,usercode=@userCode where d_c='cr' and autormk=@AutoRmk and comid=@comid


				end	


			end








---if credit purchase

			if @acctHead not in ('purchase','cash purchase')
			begin
			select @drHeadid=headid from head where comid=@comid and HeadName in ('purchase','cash purchase')
			select @crHeadid =headid from head where headname =@acctHead and comid=@comid
			set @note='Purchase with Purchase Code: ' + convert(varchar,@purchaseCode) + '  from ' + @AcctHead

				if @existOrNot=0
				begin
				select @vno=isnull(max(convert(int,voucherno)),0)+1 from voucherMstr where isnumeric(voucherno)=1

				delete from voucherMstr where autoRmk=@autoRmk and comid=@comid
				delete from voucher where autoRmk=@autoRmk and comid=@comid
		
				insert vouchermstr(voucherno,vdate,comid,usercode,pcname,autormk) values (@vno,convert(datetime,@PurDate,103),@comid,@usercode,@pcname,@AutoRmk)
				select @autoNoFromVrMstr=autoNo from vouchermstr where autormk=@AutoRmk

				insert into voucher (autoNoFromMstrTbl,voucherno,headid,dr,note,autormk,pcname,usercode,d_c,comid) values (@autoNoFromVrMstr,@vno,@Drheadid,@TotAmt,@note ,@AutoRmk,@pcname,@usercode,'Dr',@comid)
				insert into voucher (autoNoFromMstrTbl,voucherno,headid,cr,note,autormk,pcname,usercode,d_c,comid) values (@autoNoFromVrMstr,@vno,@Crheadid,@TotAmt,@note,@AutoRmk,@pcname,@usercode,'Cr',@comid)
					if @cashAmt>0
					begin
					select @drHeadid=headid from head where comid=@comid and HeadName =@acctHead
--					select @crHeadid =headid from head where HeadName in ('cash','cash in hand','petty cash') and comid=@comid
					select @crHeadid =headid from head where HeadName =@crHeadNameFromPurchase and comid=@comid
					set @note='Cash Paid to ' + @AcctHead + '  in ' + convert(varchar,@purchaseCode)

					insert into voucher (autoNoFromMstrTbl,voucherno,headid,dr,note,autormk,pcname,usercode,d_c,comid) values (@autoNoFromVrMstr,@vno,@Drheadid,@CashAmt,@note ,@AutoRmk,@pcname,@usercode,'Dr',@comid)
					insert into voucher (autoNoFromMstrTbl,voucherno,headid,cr,note,autormk,pcname,usercode,d_c,comid) values (@autoNoFromVrMstr,@vno,@Crheadid,@CashAmt,@note,@AutoRmk,@pcname,@usercode,'Cr',@comid)
					end
				end	

				if @existOrNot=1
				begin
		--		select @vno=voucherno from voucherMstr where isnumeric(voucherno)=1

				update vouchermstr set vdate=convert(datetime,@PurDate,103),usercode=@usercode,pcname=@pcname where autormk=@AutoRmk and comid=@comid

				update voucher set dr=@TotAmt,pcname=@pcname,usercode=@userCode where d_c='dr' and autormk=@AutoRmk and comid=@comid
				update voucher set cr=@TotAmt,pcname=@pcname,usercode=@userCode where d_c='cr' and autormk=@AutoRmk and comid=@comid

					if @cashAmt>0
					begin
					select @drHeadid=headid from head where comid=@comid and HeadName =@acctHead
--					select @crHeadid =headid from head where HeadName in ('cash','cash in hand','petty cash') and comid=@comid
					select @crHeadid =headid from head where HeadName =@crHeadNameFromPurchase and comid=@comid

					update voucher set dr=@CashAmt,pcname=@pcname,usercode=@userCode where d_c='dr' and autormk=@AutoRmk and comid=@comid
					update voucher set cr=@CashAmt,pcname=@pcname,usercode=@userCode where d_c='cr' and autormk=@AutoRmk and comid=@comid
					end

				end	
			end



GO
/****** Object:  StoredProcedure [dbo].[SpAutoVrFromSales]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO



--Select * from SaleMstr

CREATE  PROCEDURE [dbo].[SpAutoVrFromSales] @SalesAutoNo numeric,@ComId varchar(10),@userCode varchar(100) ,@pcName varchar(100),@CashAmt money

as
-- exec SpAutoVrFromSales 116, '1','' ,'',4000
declare @vNo varchar(100),@partyName varchar(100),@PartyCode varchar(100),@acctHead varchar(200),@existOrNot int,@source varchar(100),@headId money
,@opBal money,@OpBalDate varchar(100),@autoRmk varchar(200),@drHeadId int,@crHeadId int,@drCr varchar(10),@InvoiceNo varchar(20)
,@autoNoFromVrMstr money,@partyAutoNo int,@SaleDate datetime,@note varchar(200),@TotAmt money,@rmk varchar(200)

delete from tem

set @autoRmk='Auto Vr from Sales Auto No ' + convert(varchar,@SalesAutoNo)

select @partyAutoNo=partyAuto,@SaleDate=SaleDate,@InvoiceNo=invoiceNo,@TotAmt=payable,@rmk=rmk from saleMstr where autono=@SalesAutoNo

insert into tem (rmk) values ('partyauto= ' + convert(varchar,@partyAutoNo) + ' salesauto= ' + convert(varchar,@SalesAutoNo))

select @acctHead=acctHead, @source='Party - ' + convert(varchar,@partyAutoNo),@opBal=opbal,@opBalDate=convert(datetime,opbaldate,103)
,@drCr=drCr,@partyName=PartyName from partyInfo where autono=@partyAutoNo


insert into tem (rmk) values ('AcctHead= ' + @acctHead)

	set @existOrNot=0
	select @existOrNot=count(m.voucherno) from voucherMstr m,voucher d where m.autono=d.autoNoFromMstrTbl and m.autoRmk=@autoRmk

insert into tem (rmk) values ('exist or not = ' + convert(varchar,@existOrNot))

-- if  cash purchase
			if @acctHead like 'sale%' or @acctHead like 'sel%'
			begin
			select @crHeadid=headid from head where comid=@comid and HeadName like 'sale%'
			select @drHeadid =headid from head where headname in ('Cash','Cash in hand','petty cash') and comid=@comid
			set @note='Cash Sale Invoice No: ' + convert(varchar,@InvoiceNo) 


				if @existOrNot=0
				begin
				select @vno=isnull(max(convert(int,voucherno)),0)+1 from voucherMstr where isnumeric(voucherno)=1

				delete from voucherMstr where autoRmk=@autoRmk and comid=@comid
				delete from voucher where autoRmk=@autoRmk and comid=@comid
		
				insert vouchermstr(voucherno,vdate,comid,usercode,pcname,autormk) values (@vno,convert(datetime,@SaleDate,103),@comid,@usercode,@pcname,@AutoRmk)
				select @autoNoFromVrMstr=autoNo from vouchermstr where autormk=@AutoRmk

				insert into voucher (autoNoFromMstrTbl,voucherno,headid,dr,note,autormk,pcname,usercode,d_c) values (@autoNoFromVrMstr,@vno,@Drheadid,@CashAmt,@note ,@AutoRmk,@pcname,@usercode,'Dr')
				insert into voucher (autoNoFromMstrTbl,voucherno,headid,cr,note,autormk,pcname,usercode,d_c) values (@autoNoFromVrMstr,@vno,@Crheadid,@CashAmt,@note,@AutoRmk,@pcname,@usercode,'Cr')
				end	





				if @existOrNot>=1
				begin
		--		select @vno=voucherno from voucherMstr where isnumeric(voucherno)=1

				update vouchermstr set vdate=convert(datetime,@SaleDate,103),usercode=@usercode,pcname=@pcname where autormk=@AutoRmk and comid=@comid

				update voucher set dr=@CashAmt,pcname=@pcname,usercode=@userCode where d_c='dr' and autormk=@AutoRmk and comid=@comid
				update voucher set cr=@CashAmt,pcname=@pcname,usercode=@userCode where d_c='cr' and autormk=@AutoRmk and comid=@comid


				end	


			end








---if credit purchase

			if @acctHead not in ('sales','cash sale','sale','sell','sells')
			begin
--			select @crHeadid=headid from head where comid=@comid and HeadName in ('sales','cash sale','sale','sell','sells')
			select @crHeadid=crHeadId from saleMstr where comid=@comid and autoNo=@SalesAutoNo
			select @drHeadid =headid from head where headname =@acctHead and comid=@comid
			set @note='Sales Invoice No: ' + convert(varchar,@InvoiceNo) + '  to ' + @AcctHead

insert into tem (rmk) values ('CrHeadId = ' + convert(varchar,@crHeadId) + '  DrHeadId ' + convert(varchar,@DrHeadId))
				if @existOrNot=0
				begin
				select @vno=isnull(max(convert(int,voucherno)),0)+1 from voucherMstr where isnumeric(voucherno)=1

				delete from voucherMstr where autoRmk=@autoRmk and comid=@comid
				delete from voucher where autoRmk=@autoRmk and comid=@comid
		
				insert vouchermstr(voucherno,vdate,comid,usercode,pcname,autormk) values (@vno,convert(datetime,@SaleDate,103),@comid,@usercode,@pcname,@AutoRmk)
				select @autoNoFromVrMstr=autoNo,@vNo=voucherNo from vouchermstr where autormk=@AutoRmk

insert into tem (rmk) values ('1')
				set @note='Sales Invoice No: ' + convert(varchar,@InvoiceNo)
				insert into voucher (autoNoFromMstrTbl,voucherno,headid,dr,note,autormk,pcname,usercode,d_c,notermk,rmk) values (@autoNoFromVrMstr,@vno,@Drheadid,@TotAmt,@note ,@AutoRmk,@pcname,@usercode,'Dr',@note,@rmk)
				set @note='Sales Invoice No: ' + convert(varchar,@InvoiceNo) + '  to ' + @AcctHead
				insert into voucher (autoNoFromMstrTbl,voucherno,headid,cr,note,autormk,pcname,usercode,d_c,noteRmk,rmk) values (@autoNoFromVrMstr,@vno,@Crheadid,@TotAmt,@note,@AutoRmk,@pcname,@usercode,'Cr',@note,@rmk)
insert into tem (rmk) values ('2')
					if @cashAmt>0
					begin
insert into tem (rmk) values (@note)
					select @crHeadid=headid from head where comid=@comid and HeadName =@acctHead
					select @drHeadid =headid from head where HeadName in ('cash','cash in hand','petty cash') and comid=@comid
					set @note='Cash Received from ' + @AcctHead + '   Invoice No: ' + convert(varchar,@InvoiceNo)

					insert into voucher (autoNoFromMstrTbl,voucherno,headid,dr,note,autormk,pcname,usercode,d_c) values (@autoNoFromVrMstr,@vno,@Drheadid,@CashAmt,@note ,@AutoRmk,@pcname,@usercode,'Dr')
					set @note='Cash Received by Invoice No: ' + convert(varchar,@InvoiceNo)
					insert into voucher (autoNoFromMstrTbl,voucherno,headid,cr,note,autormk,pcname,usercode,d_c) values (@autoNoFromVrMstr,@vno,@Crheadid,@CashAmt,@note,@AutoRmk,@pcname,@usercode,'Cr')
					end
				end	

				if @existOrNot>=1
				begin
		--		select @vno=voucherno from voucherMstr where isnumeric(voucherno)=1

insert into tem (rmk) values ('3')
				update vouchermstr set vdate=convert(datetime,@SaleDate,103),usercode=@usercode,pcname=@pcname where autormk=@AutoRmk and comid=@comid
				
				
				select @autoNoFromVrMstr=autoNo,@vNo=voucherNo from vouchermstr where autormk=@AutoRmk
				delete from voucher where autoRmk=@autoRmk and comid=@comid

--				update voucher set dr=@TotAmt,pcname=@pcname,usercode=@userCode,note=@note where d_c='dr' and autormk=@AutoRmk and comid=@comid
--				update voucher set cr=@TotAmt,pcname=@pcname,usercode=@userCode,note=@note where d_c='cr' and autormk=@AutoRmk and comid=@comid
				set @note='Sales Invoice No: ' + convert(varchar,@InvoiceNo)
				insert into voucher (autoNoFromMstrTbl,voucherno,headid,dr,note,autormk,pcname,usercode,d_c,noteRmk,rmk) values (@autoNoFromVrMstr,@vno,@Drheadid,@TotAmt,@note ,@AutoRmk,@pcname,@usercode,'Dr',@note,@rmk)
				set @note='Sales Invoice No: ' + convert(varchar,@InvoiceNo) + '  to ' + @AcctHead
				insert into voucher (autoNoFromMstrTbl,voucherno,headid,cr,note,autormk,pcname,usercode,d_c,noteRmk,rmk) values (@autoNoFromVrMstr,@vno,@Crheadid,@TotAmt,@note,@AutoRmk,@pcname,@usercode,'Cr',@note,@rmk)

					if @cashAmt>0
					begin

insert into tem (rmk) values ('4')
					select @crHeadid=headid from head where comid=@comid and HeadName =@acctHead
					select @drHeadid =headid from head where HeadName in ('cash','cash in hand','petty cash') and comid=@comid

--					update voucher set dr=@CashAmt,pcname=@pcname,usercode=@userCode where d_c='dr' and autormk=@AutoRmk and comid=@comid
--					update voucher set cr=@CashAmt,pcname=@pcname,usercode=@userCode where d_c='cr' and autormk=@AutoRmk and comid=@comid
					set @note='Cash Received from ' + @AcctHead + '   Invoice No: ' + convert(varchar,@InvoiceNo)
					insert into voucher (autoNoFromMstrTbl,voucherno,headid,dr,note,autormk,pcname,usercode,d_c) values (@autoNoFromVrMstr,@vno,@Drheadid,@CashAmt,@note ,@AutoRmk,@pcname,@usercode,'Dr')
					set @note='Cash Received by Invoice No: ' + convert(varchar,@InvoiceNo)
					insert into voucher (autoNoFromMstrTbl,voucherno,headid,cr,note,autormk,pcname,usercode,d_c) values (@autoNoFromVrMstr,@vno,@Crheadid,@CashAmt,@note,@AutoRmk,@pcname,@usercode,'Cr')

					end

				end	
			end




GO
/****** Object:  StoredProcedure [dbo].[SPBonus]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO







CREATE PROCEDURE [dbo].[SPBonus] @ComID varchar(20),@ForMonth varchar(10),@ForYear varchar(10),@DOE varchar(10)
,@DojAfter varchar(10),@FName varchar(100)
AS


delete from bonus where formonth=@formonth and foryear=@foryear


insert bonus(empAutono,formonth,foryear,gross,basic,bonusAmt,doe,comid,fname,sp)
select e.empautoNO,@forMOnth,@forYear,grossUsd,round((grossUsd-1100)/1.4,0),round(gross*0.45,0),convert(datetime,@doe,103),@comid,@fname
,datediff(dd,joindate,convert(datetime,@doe,103)) from employee e where 
active=1 and joindate<=convert(datetime,@dojAfter,103) and saltype<>'1'


insert bonus(empAutono,formonth,foryear,gross,basic,bonusAmt,doe,comid,fname,sp)
select e.empautoNO,@forMOnth,@forYear,grossUsd,round((grossUsd-1100)/1.4,0),allnc,convert(datetime,@doe,103),@comid,@fname
,datediff(dd,joindate,convert(datetime,@doe,103)) from employee e where 
active=1 and joindate<=convert(datetime,@dojAfter,103) and saltype='1'







GO
/****** Object:  StoredProcedure [dbo].[SpBS]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO



CREATE PROCEDURE [dbo].[SpBS]
@comid varchar(50),@PCNAME varchar(50),@tillDAte varchar(50),@userId varchar(50)
 AS


declare @FromDate varchar(10),@asst money ,@laibility money,@CInHand money,@CAtBank money
,@SDebitor money,@SCreditor money,@BankLoan money,@PROFIT money,@LOSS money,@otherAsset money
,@OtherLib money,@drBal money,@crBal money,@Reslt money,@SHead money,@opbal money,@HeadName money
,@prvDr money, @prvCr money,@PLACCTHEAD money,@i money,@debit money,@credit money,@AccountsPayable money,@AccountsReceivable money
,@LoanPayable money,@LoanReceivable money,@closingStock money,@netProfit money,@netLoss Money

set @debit = 0
set @credit = 0
select @FromDate=convert(varchar,isnull(min(vdate),getdate()),103) from vouchermstr

exec spTBProcess @comid,@tillDAte,@PCNAME

exec SpPLAc @comid,@pcName,@FromDate,@tillDAte,@userId

set @closingStock=0
--select @closingStock=headAmtDr+HeadAmtCr from temTradAc where comid=@comid and pcname=@pcname and head='closing stock'
select @closingStock=isnull(sum(closingTotalPrice),0) from stockRpt where comid=@comid and pcname=@pcname

delete from bs where comid=@comid and pcname=@pcname

insert bs (bstype,debit,comid,pcname,grp) select at.Type,isnull(sum(debit),0)-isnull(sum(credit),0),@comid,@pcname,'Asset'
from tb ,head h,accttype at where h.type=at.type and h.comid=at.comid and h.headname=tb.headname and
h.comid=tb.comid and tb.comid=@comid and tb.pcname=@pcname 
and at.destination in ('cash','cash in hand','patyy cash','Cash at Bank','Bank','Current Asset','Fixed Asset','Others Asset','Advance')
group by at.type

insert bs (bstype,credit,comid,pcname,grp) select at.Type,isnull(sum(credit),0)-isnull(sum(debit),0),@comid,@pcname,'Liabilities'
from tb ,head h,accttype at where h.type=at.type and h.comid=at.comid and h.headname=tb.headname and
h.comid=tb.comid and tb.comid=@comid and tb.pcname=@pcname
and at.destination in ('Capital','Current Liabilities','Others Liabilities')
group by at.type

insert bs (bstype,debit,comid,pcname,grp) select 'Accounts Receivable (From Party)',isnull(sum(debit),0),@comid,@pcName,'Asset'
from tb ,head h,accttype at where h.type=at.type and h.comid=at.comid and h.headname=tb.headname and
h.comid=tb.comid and tb.comid=@comid and tb.pcname=@pcName
and at.destination in ('Accounts Payable/Receivable')
group by at.type

insert bs (bstype,debit,comid,pcname,grp) select 'Accounts Receivable (Loan)',isnull(sum(debit),0),@comid,@pcName,'Asset'
from tb ,head h,accttype at where h.type=at.type and h.comid=at.comid and h.headname=tb.headname and
h.comid=tb.comid and tb.comid=@comid and tb.pcname=@pcName
and at.destination in ('Loan Payable/Receivable')
group by at.type


insert bs (bstype,credit,comid,pcname,grp) select 'Accounts Payable',isnull(sum(credit),0),@comid,@pcName,'Liabilities'
from tb ,head h,accttype at where h.type=at.type and h.comid=at.comid and h.headname=tb.headname and
h.comid=tb.comid and tb.comid=@comid and tb.pcname=@pcName
and at.destination in ('Accounts Payable/Receivable','Loan Payable/Receivable')
group by at.type

set @netProfit=0
set @netLoss=0

select @netProfit= isnull(headamtdr-headAmtCr,0) from temTradAc where head like 'net %' and pcname=@pcname 
and comid=@comid and headamtdr-headAmtCr>0

select @netloss=isnull(headamtdr-headAmtCr,0) from temTradAc where head like 'net %' and pcname=@pcname 
and comid=@comid and headamtdr-headAmtCr<0

update bs set credit=credit+@netProfit+@netloss where comid=@comid and pcname=@pcname and bstype='capital'

/*
update bs set credit=credit+(select headamtdr-headAmtCr from temTradAc where head like 'net %' and pcname=@pcname 
and comid=@comid and headamtdr-headAmtCr<0) where comid=@comid and pcname=@pcname and bstype='capital'
*/


insert into bs (bstype,debit,comid,pcname,grp) values ('Closing Stock',@closingStock,@comid,@pcname,'Asset')



GO
/****** Object:  StoredProcedure [dbo].[SpCreatePartyHead]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO













CREATE PROCEDURE [dbo].[SpCreatePartyHead] @partyAutoNo int,@ComId varchar(10),
@userCode varchar(100) ,@pcName varchar(100)

as

declare @vNo varchar(100),@partyName varchar(100),@PartyCode varchar(100),@acctHead varchar(200),@existOrNot int,@source varchar(100),@headId money
,@opBal money,@OpBalDate varchar(100),@autoRmk varchar(200),@drHeadId int,@crHeadId int,@drCr varchar(10)
,@autoNoFromVrMstr money

select @acctHead=PartyName + '-' + partyCode, @source='Party-' + convert(varchar,@partyAutoNo),@opBal=opbal,@opBalDate=convert(datetime,opbaldate,103)
,@drCr=drCr from partyInfo where autono=@partyAutoNo

update Partyinfo set accthead=@acctHead where autono=@partyAutoNo
update Partyinfo set accthead=PartyName where partyname in ('cash purchase','sales','cash sale','purchase','Sell','Sells') and comid=@comid


set @existOrNot=0

select @existOrNot=count(headid) from head where source=@source

	if @existOrNot=0
	begin
	insert Head (headname,Type,Source,ComiD,pcname,usercode,opbal,opbaldate,hgroup) 
	select accthead,'Party',@source ,@ComId, @PcName, @usercode,opbal,opbaldate,PartyType from Partyinfo where autono=@partyAutoNo
	end


	if @existOrNot=1
	begin
	update head set headname=@acctHead,UserCode=@userCode,pcname=@pcName where source=@source
	update head set head.headname=PartyInfo.acctHead,Head.UserCode=PartyInfo.userCode,Head.pcname=PartyInfo.pcName,head.opbal=PartyInfo.OpBal,
head.opbalDate=partyInfo.opBalDate,head.HGroup=partyInfo.PartyType,Type='Party' from PartyInfo where head.HeadName=PartyInfo.acctHead and head.comid=PartyInfo.Comid and head.source=@source
and headname not like 'cash pur%' and headname not like 'cash s%'  

update head set type='Sales' where headname in ('sales','cash sale','sale','sell','sells')
update head set type='Purchase' where headname in ('purchase','cash purchase')
	
	end

set @autoRmk=''

	if @opBal>0 
	begin
	set @autoRmk='Opening Balance of ' + @source

	set @existOrNot=0
	select @existOrNot=count(voucherno) from voucherMstr where autoRmk=@autoRmk

		if @existOrNot=0
		begin
		select @vno=isnull(max(convert(int,voucherno)),0)+1 from voucherMstr where isnumeric(voucherno)=1

		delete from voucherMstr where autoRmk=@autoRmk and comid=@comid
		delete from voucher where autoRmk=@autoRmk and comid=@comid

		insert vouchermstr(voucherno,vdate,comid,usercode,pcname,autormk) values (@vno,convert(datetime,@opbaldate,103),@comid,@usercode,@pcname,@AutoRmk)
		select @autoNoFromVrMstr=autoNo from vouchermstr where autormk=@AutoRmk

			if @drcr='dr'
			begin
			select @drHeadid =headid from head where source=@source and comid=@comid
			select @crHeadid =headid from head where headname='Capital' and comid=@comid
			end


			if @drcr='cr'
			begin
			select @crHeadid =headid from head where source=@source and comid=@comid
			select @drHeadid =headid from head where headname='Capital' and comid=@comid
			end

		insert into voucher (autoNoFromMstrTbl,voucherno,headid,dr,note,autormk,pcname,usercode,d_c) values (@autoNoFromVrMstr,@vno,@Drheadid,@opBal,'Opening Balance',@AutoRmk,@pcname,@usercode,'Dr')
		insert into voucher (autoNoFromMstrTbl,voucherno,headid,cr,note,autormk,pcname,usercode,d_c) values (@autoNoFromVrMstr,@vno,@Crheadid,@opBal,'Opening Balance',@AutoRmk,@pcname,@usercode,'Cr')
		end	






		if @existOrNot=1
		begin
--		select @vno=voucherno from voucherMstr where isnumeric(voucherno)=1

		update vouchermstr set vdate=convert(datetime,@opbaldate,103),usercode=@usercode,pcname=@pcname where autormk=@AutoRmk and comid=@comid

			if @drcr='dr'
			begin
			select @drHeadid =headid from head where source=@source and comid=@comid
			select @crHeadid =headid from head where headname='Capital' and comid=@comid
			end


			if @drcr='cr'
			begin
			select @crHeadid =headid from head where source=@source and comid=@comid
			select @drHeadid =headid from head where headname='Capital' and comid=@comid
			end

		update voucher set dr=@OpBal,pcname=@pcname,usercode=@userCode where d_c='dr' and autormk=@AutoRmk and comid=@comid
		update voucher set cr=@OpBal,pcname=@pcname,usercode=@userCode where d_c='cr' and autormk=@AutoRmk and comid=@comid


		end	

	end



GO
/****** Object:  StoredProcedure [dbo].[SpDailyAttnLeaveUpdate]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO



























CREATE PROCEDURE [dbo].[SpDailyAttnLeaveUpdate]
	@Formonthno int
	,@ForYear varchar(4)
	
As
	Declare  @Empid varchar(10),@AMOUNT MONEY,@fromDate datetime,@toDate datetime,@typeOfLeave varchar(10),@CL int,@SL int ,@EL int ,@ML int 




	Declare curSAL Cursor
	Forward_Only
	Keyset
	Scroll_locks
For
select empid,fromdate,todate,typeofleave from leavetransaction where month(FROMDATE)=@ForMonthNo and year(fromdate)=@ForYear
	Open curSAL
	Fetch  from curSAL into @EmpID,@fromdate,@todate,@typeofleave
	while @@Fetch_Status=0
	
	BEGIN

set @CL=0
set @sL=0
set @ML=0
set @EL=0

if @typeofleave='CL'
Begin
set @CL=1
end

if @typeofleave='SL'
Begin
set @SL=1
end

if @typeofleave='EL'
Begin
set @EL=1
end

if @typeofleave='ML'
Begin
set @ML=1
end


update dailyattn set status='A',CL=@CL,SL=@SL,EL=@EL,ML=@ML,ib=null,i=null,o=null,ob=null,othr=0,othrb=0,ot=0,otb=0,presentqty=0,leaveqty=1,absentqty=1,rem=@typeofleave,leave=@typeofleave,holidayqty=0 where empid=@empid and attndate between convert(datetime,@fromdate,103) and convert(datetime,@todate,103)

if @typeofleave='hl'
begin
update dailyattn set status='A',ib=null,i=null,o=null,ob=null,othr=0,othrb=0,ot=0,otb=0,presentqty=0,leaveqty=0,absentqty=1,rem='(Adj HL)',Holidayqty=1,holiDay=@typeofleave where empid=@empid and attndate between convert(datetime,@fromdate,103) and convert(datetime,@todate,103)
end



	Fetch from curSAL into @EmpID,@fromdate,@todate,@typeofleave


if @@Error <> 0
		Begin
		Rollback Transaction
		Raiserror('Insertion Failed',16,1)
		Return -1
		End	
	End
Deallocate curSAL
























GO
/****** Object:  StoredProcedure [dbo].[SpDailyAttnProcess]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO










CREATE PROCEDURE [dbo].[SpDailyAttnProcess]
@forMonthNo int, @forYear int,@comid varchar(10)
AS

exec SpShiftTimeUpdate @forMonthNo, @forYear,@comid

update employee set terminationdate=null where year(terminationdate)=1900

update dailyattn set presentqty=0,absentqty=1,aqty=1,leaveqty=0,holidayqty=0,Status='A',otHr=0,otmnt=0,ot=0,LateQty=0,
LateRmk='',singleEntry=0,earlyOut=0,rem='',Govholiday =0, holidayWork=0,HoliDayRmk='',totalEmp=1
,malea=1,femalea=1
  WHERE MONTH(ATTNDATE)=@forMonthNo AND YEAR(ATTNDATE)=@forYear  and comid=@comid

exec SPLeaveProcess @FormonthNo,@ForYear,@comid
exec SPHolidayProcess @FormonthNo,@ForYear,@comid


update dailyattn set presentqty=1,absentqty=0,Status='P',pqty=1,aqty=0  WHERE MONTH(ATTNDATE)=@forMonthNo AND YEAR(ATTNDATE)=@forYear  and comid=@comid and 
i>convert(datetime,'00:00:00',108)
update dailyattn set presentqty=1,absentqty=0,Status='P',pqty=1,aqty=0  WHERE MONTH(ATTNDATE)=@forMonthNo AND YEAR(ATTNDATE)=@forYear  and comid=@comid and 
o>convert(datetime,'00:00:00',108)


update dailyattn set LateQty =1,LateRmk='Late' where  MONTH(ATTNDATE)=@forMonthNo and YEAR(ATTNDATE)=@forYear and i>GblMaxInTime and comid=@comid
--update dailyattn set earlyOut =1,LateRmk='Early Out' where  MONTH(ATTNDATE)=@forMonthNo and YEAR(ATTNDATE)=@forYear and o<GblOutTime and comid=@comid

--update dailyattn set absentqty =1,rem='Absent' ,LateRmk='' where Status ='A'  and  LeaveQty =0 and HolidayQty =0  and GovHoliday =0 and MONTH(ATTNDATE)=@forMonthNo and YEAR(ATTNDATE)=@forYear 

update dailyattn set holidayWork=1 where isnull(holidayqty,0)=1 and i>convert(datetime,'00:00:00',108) and month(attndate)=@forMOnthno and year(attndate)=@foryear 


update dailyattn set holidayWork=1,otstart=dateadd(n,60,i) where isnull(holidayqty,0)=1 and i>convert(datetime,'00:00:00',108)  and  i<convert(datetime,'12:00:00',108) 
and month(attndate)=@forMOnthno and year(attndate)=@foryear 

update dailyattn set holidayWork=1,otstart=dateadd(n,0,i) where isnull(holidayqty,0)=1
and month(attndate)=@forMOnthno and year(attndate)=@foryear 
  and (i>convert(datetime,'12:00:00',108) or o<convert(datetime,'14:00:00',108))

update dailyattn set otstart=dateadd(n,60,dateadd(DD,-1,OTSTART)) where  month(attndate)=@forMOnthno and year(attndate)=@foryear
   and O>convert(datetime,'00:00:00',108) AND o<=convert(datetime,'07:00:00',108)


update dailyattn set otmnt=DATEDIFF(n,otstart,o)  WHERE MONTH(ATTNDATE)=@forMonthNo AND YEAR(ATTNDATE)=@forYear 
 and comid=@comid AND PRESENTQTY=1 and o>convert(datetime,'00:00:00',108) and  datepart(hh,otstart)>0

update dailyattn set othr=floor(otmnt/60) WHERE MONTH(ATTNDATE)=@forMonthNo AND YEAR(ATTNDATE)=@forYear  AND PRESENTQTY=1 and comid=@comid

update dailyattn set othr=0,otmnt=0 WHERE MONTH(ATTNDATE)=@forMonthNo AND YEAR(ATTNDATE)=@forYear  and comid=@comid AND (othr<0 or otmnt<0)

update dailyattn set otmnt=otmnt - othr*60 WHERE MONTH(ATTNDATE)=@forMonthNo AND YEAR(ATTNDATE)=@forYear and comid=@comid

update dailyattn set otmnt=0 WHERE MONTH(ATTNDATE)=@forMonthNo AND YEAR(ATTNDATE)=@forYear and otmnt<25 and comid=@comid
update dailyattn set otmnt=0.5 WHERE MONTH(ATTNDATE)=@forMonthNo AND YEAR(ATTNDATE)=@forYear and otmnt>=25 AND otmnt<55 and comid=@comid
update dailyattn set otmnt=1 WHERE MONTH(ATTNDATE)=@forMonthNo AND YEAR(ATTNDATE)=@forYear and otmnt>=55 and comid=@comid

update dailyattn set ot=othr+otmnt,otb=othr+otmnt WHERE MONTH(ATTNDATE)=@forMonthNo AND YEAR(ATTNDATE)=@forYear  and comid=@comid


update dailyattn set otb=maxot WHERE MONTH(ATTNDATE)=@forMonthNo AND YEAR(ATTNDATE)=@forYear and ot>maxot and comid=@comid
and empautono not in (select empautono from vwallemp where desg like 'security%')


update dailyattn set extraOTHr=ot-otb WHERE MONTH(ATTNDATE)=@forMonthNo AND YEAR(ATTNDATE)=@forYear and ot>maxot and comid=@comid 

--update dailyattn set i=null where i>dateadd(hh,1,gblInTime) and MONTH(ATTNDATE)=@forMonthNo AND YEAR(ATTNDATE)=@forYear and comid=@comid
--update dailyattn set o=null where O>convert(DATETIME,'06:00:00',108) AND  o<dateadd(hh,-6,gbloutTime) and MONTH(ATTNDATE)=@forMonthNo AND YEAR(ATTNDATE)=@forYear and comid=@comid

update Dailyattn set singleEntry=1 where  comid=@comid and (i>convert(datetime,'00:00:00',108) or i>convert(datetime,'00:00:00',108)) and (i=o or i is null or o is null)


update Dailyattn set ib=i,ob=o where  MONTH(ATTNDATE)=@forMonthNo AND YEAR(ATTNDATE)=@forYear and comid=@comid

update Dailyattn set ib=null,ob=null,otb=0,Status='A',otstart=null,presentqty=0,absentqty=1  where  MONTH(ATTNDATE)=@forMonthNo AND YEAR(ATTNDATE)=@forYear and comid=@comid
and holidayqty+govHoliday>0


update Dailyattn set ob=dateadd(hh,MaxOt,gblouttime) where Ot>Maxot and  MONTH(ATTNDATE)=@forMonthNo AND YEAR(ATTNDATE)=@forYear and comid=@comid
and empautono not in (select empautono from vwallemp where desg like 'security%')


update dailyattn set male=1,female=0,femalep=0,femalea=0 where  MONTH(ATTNDATE)=@forMonthNo AND YEAR(ATTNDATE)=@forYear and comid=@comid
and empid in (select empid from employee where sex='male')

update dailyattn set male=0,female=1,malea=0,malep=0 where  MONTH(ATTNDATE)=@forMonthNo AND YEAR(ATTNDATE)=@forYear and comid=@comid
and  empid in (select empid from employee where sex<>'male')

update dailyattn set malep=1,malea=0,femalep=0,femalea=0 where presentqty=1 and 
 MONTH(ATTNDATE)=@forMonthNo AND YEAR(ATTNDATE)=@forYear and comid=@comid and  empid in (select empid from employee where sex='male')

update dailyattn set femalep=1,femalea=0, malep=0,malea=0 where presentqty=1 and   MONTH(ATTNDATE)=@forMonthNo AND YEAR(ATTNDATE)=@forYear and comid=@comid
and empid in (select empid from employee where sex<>'male')

update Dailyattn set ot=0,otb=0 where  MONTH(ATTNDATE)=@forMonthNo AND YEAR(ATTNDATE)=@forYear and comid=@comid and empautono in (select empautono from employee where overtime=0)

update Dailyattn set ob=dateadd(ss,datepart(ss,deviceIn)*3,ob) where  MONTH(ATTNDATE)=@forMonthNo AND YEAR(ATTNDATE)=@forYear and comid=@comid 
and datepart(n,ob)=0 and datepart(ss,ob)=0 and datepart(hh,ob)>0 and datepart(hh,deviceIn)>0

update Dailyattn set ot=ot-1 where  MONTH(ATTNDATE)=@forMonthNo AND YEAR(ATTNDATE)=@forYear and comid=@comid
 and ot>1 and o>convert(datetime,'00:00:00',108) and o<convert(datetime,'07:00:00',108) and holidayqty=1

update dailyattn set ob=null,ib=null,presentqty=0,absentqty=1 where holidayqty=1 and 
 MONTH(ATTNDATE)=@forMonthNo AND YEAR(ATTNDATE)=@forYear and comid=@comid 

exec SpRandom @formonthNO,@foryear







GO
/****** Object:  StoredProcedure [dbo].[SPDataBaseBak]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO





















CREATE PROCEDURE [dbo].[SPDataBaseBak]

@D_BaseMedia Varchar(100),
@D_BasePath varchar(300),
@D_BaseNAme varchar(30)
AS

execute SP_Addumpdevice "Disk", @D_BaseMedia,@D_BasePath
backup Database @D_BaseName to @D_BaseMedia
execute SP_DropDevice @D_BaseMedia






GO
/****** Object:  StoredProcedure [dbo].[SpEarnLeave]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO




















CREATE Procedure [dbo].[SpEarnLeave]
		@ForYear varchar(10)
                            ,@ELBased varchar(10)
		,@FromDate varchar(10)
		,@ToDate varchar(10)

As
Declare @EmpID varchar(10),@gross money,@basic money,@ELAmount money,@ServiceDay Money,@ELDay Money,@ComId varchar(10)

DELETE FROM ELCALCULATION WHERE  FORYEAR=@FORYEAR


	Declare CurBonusEid Cursor
	Forward_only
	Keyset
	Scroll_locks
	For
	Select EmpID,gross,basic,ComId
	from Employee where Active=1 and JoinDate between convert(datetime,@FromDate,103)  AND convert(datetime,@ToDate,103) 

	
	Open curBonusEid
	Fetch next from curBonusEid into @EmpID,@gross,@basic,@ComId

	while @@Fetch_Status=0
	Begin

              set @ELAmount =0 

Select @ServiceDay=sum(attnday) From Monsalary where Foryear=@ForYear and  empid =@EmpID

Select @ELDay=Elbal From leavebalance where Foryear=@ForYear and  empid =@EmpID


if @ELBased='Gross'
begin
set @ELAmount=(isnull(@ELDay,0) * (@Gross/30))
end


if @ELBased='Basic'
begin
set @ELAmount=(isnull(@ELDay,0) * (@Basic/30))
end


Insert into ELCALCULATION (ForYear,EmpID,Amount,totWorkDay,elday,ComId)
values(@ForYear,@EmpID,round(isnull(@ELAmount,0),0),isnull(@ServiceDay,0),isnull(@ELDay,0),@ComId)


Fetch next from curBonusEid into @EmpID,@gross,@basic,@ComId



		if @@Error <> 0  
		Begin
		Rollback Transaction
		Raiserror('Insertion Failed',16,1)
		Return -1
		End	
end
deallocate CurBonusEid


















GO
/****** Object:  StoredProcedure [dbo].[SpFestivalBonus]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO




















CREATE Procedure [dbo].[SpFestivalBonus]
                             @ForMonth varchar(10)
		,@ForYear int
		,@BasicPer money
                            ,@GrossPer money
		,@FromDate varchar(10)
		,@ToDate varchar(10)
		,@EidDay varchar(10)


As
Declare @EmpID varchar(10),@gross money,@basic money,@FbonusFinal money,@joindate datetime,@ServiceDay varchar(10),@ComId varchar(10)

DELETE FROM FestivalBonus WHERE DOJ between convert(datetime,@FromDate,103)  AND convert(datetime,@ToDate,103) and FORMONTH=@FORMONTH AND FORYEAR=@FORYEAR and DOE=convert(datetime,@EidDay,103)


	Declare CurBonusEid Cursor
	Forward_only
	Keyset
	Scroll_locks
	For
	Select EmpID,JoinDate,gross,basic,ComId
	from Employee where Active=1 and JoinDate between convert(datetime,@FromDate,103)  AND convert(datetime,@ToDate,103) 

	
	Open curBonusEid
	Fetch next from curBonusEid into @EmpID,@joinDate,@gross,@basic,@ComId

	while @@Fetch_Status=0
	Begin
              set @Fbonusfinal =0 

set @ServiceDay=datediff(d,@joinDate,convert(datetime,@EidDay,103))+1

if @grossper<>0
begin
set @FbonusFinal=(@gross*@grossPer)/100
end


if @basicper<>0
begin
set @FbonusFinal=(@basic*@basicPer)/100
end

Insert into FestivalBonus (ForMonth, ForYear,EmpID,DOJ,DOE,FestivalBonus,gross,basic,Serviceday,ComId)
values(@ForMonth,@ForYear,@EmpID,convert(datetime,@joinDate,103),convert(datetime,@eidDay,103),round(isnull(@FbonusFinal,0),0),round(isnull(@gross,0),0),isnull(@Basic,0),@ServiceDay,@ComId)


Fetch next from curBonusEid into @EmpID,@joinDate,@gross,@basic,@ComId

delete from FestivalBonus where FestivalBonus<=0

		if @@Error <> 0  
		Begin
		Rollback Transaction
		Raiserror('Insertion Failed',16,1)
		Return -1
		End	
end
deallocate CurBonusEid


















GO
/****** Object:  StoredProcedure [dbo].[SpHolidayGeneralUpdate]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO












CREATE PROCEDURE [dbo].[SpHolidayGeneralUpdate]
@forMonthNo int,
@forYear int
As
	Declare  @Empid varchar(10),@providentfundid varchar(10),@sectionid varchar(10),@blockID varchar(10),@HDate datetime,@HReason varchar(30)
,@gd inT,@Type varchar(100),@GovHoliDay int,@holidayqty int

	Declare curSAL Cursor
	Forward_Only
	Keyset
	Scroll_locks
For
Select reason,hdate from HolidayCalender  where  month(Hdate)=@forMonthNo and year(Hdate)=@forYear
	
	Open curSAL
	Fetch  from curSAL into @hreason,@hdate
	while @@Fetch_Status=0
	
	BEGIN

if @hreason='weekly holiday'
begin
set @holidayqty=1
set @GovHoliDay=0
end

if @hreason<>'weekly holiday'
begin
set @holidayqty=0
set @GovHoliDay=1
end
	

update dailyattn set holidayqty=@holidayqty,holiDay=@hreason,GovHoliDay=@GovHoliDay where attndate = convert(datetime,@hdate,103)

	Fetch  from curSAL into @hreason,@hdate

if @@Error <> 0
		Begin
		Rollback Transaction
		Raiserror('Insertion Failed',16,1)
		Return -1
		End	
	End
Deallocate curSAL








GO
/****** Object:  StoredProcedure [dbo].[SPHolidayProcess]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO









CREATE PROCEDURE [dbo].[SPHolidayProcess]
@ForMonthno int, @Foryear varchar(4),@comid varchar(10)
As


Declare  @Hdate datetime,@Hreason varchar(50),@HolidayQty int,@GovHoliDay int



	Declare curSAL Cursor
	Forward_Only
	Keyset
	Scroll_locks
For


Select Hdate,reason from HolidayCalender where Month(Hdate)=@ForMonthno and Year(Hdate)=@Foryear and comid=@comid
	Open curSAL
	Fetch  from curSAL into @Hdate,@Hreason
	while @@Fetch_Status=0
	
	BEGIN


if @hreason='weekly holiday'
begin
set @holidayqty=1
set @GovHoliDay=0
end

if @hreason<>'weekly holiday'
begin
set @holidayqty=0
set @GovHoliDay=1
end


            
             update dailyattn SET HolidayRmk=@Hreason,HolidayQty=1,WHOL=@HolidayQty,GovHoliDay=@GovHoliDay  WHERE attndate=CONVERT(DATETIME,@Hdate,103) and Month(attndate)=@ForMonthno and Year(attndate)=@Foryear  and comid=@comid
         

	Fetch  from curSAL into @Hdate,@Hreason

if @@Error <> 0
		Begin
		Rollback Transaction
		Raiserror('Insertion Failed',16,1)
		Return -1
		End	
	End
Deallocate curSAL







GO
/****** Object:  StoredProcedure [dbo].[spImportAttnTxtFile]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO















CREATE PROC [dbo].[spImportAttnTxtFile]

AS

declare @filePath varchar(200)

set @filePath='d:\DDntpla.txt'
--select @filePath=textFilePath from setting

insert manedit (empAutoNo,empid,attndate,i,o,ismanualtype,rmk,manualRmk)
select empautoNo,empid,attndate,i,o,ismanualtype,
convert(varchar,empautoNo)+empid+convert(varchar,attndate,103)+ convert(varchar,isnull(i,convert(datetime,'00:00:00',108)),108) 
+convert(varchar,isnull(o,convert(datetime,'00:00:00',108)),108) +ismanualtype,manualRmk
 from dailyattn where ismanualtype<>'' and convert(varchar,empautoNo)+empid+convert(varchar,attndate,103)+ convert(varchar,isnull(i,convert(datetime,'00:00:00',108)),108) 
+convert(varchar,isnull(o,convert(datetime,'00:00:00',108)),108) +ismanualtype not in (select rmk from manedit)


BULK INSERT AttnTxtFile  FROM 'd:\DDntpla.txt' WITH ( FIELDTERMINATOR ='|', FIRSTROW = 2 )

insert deviceData(rawdata) select distinct txtline from attnTxtFile where txtline not in (select rawdata from deviceData)


update devicedata set swipeDatestr=substring(rawdata,len(rawdata)-10,2) + '/' + substring(rawdata,len(rawdata)-13,2) + '/' + substring(rawdata,len(rawdata)-18,4)
,swipeTimeStr=substring(rawdata,len(rawdata)-7,8),cardno=substring(rawdata,6,3)
from deviceData where len(rawdata)>=39


delete from devicedata where cardno like '%no%'


update devicedata set swipeDate=convert(datetime,swipedatestr,103), swipeTime=convert(datetime,swipetimestr,108)











GO
/****** Object:  StoredProcedure [dbo].[SpImportToDeviceDataFromRmsSqlDb]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO











CREATE PROCEDURE [dbo].[SpImportToDeviceDataFromRmsSqlDb] @AttnDate varchar(10)
 AS

declare @AttnDateRms varchar(10)

set @attnDateRms=substring(@attnDate,7,4)+substring(@attnDate,4,2)+substring(@attnDate,1,2)

if  convert(datetime,@attndate,103)>=convert(datetime,'01/04/2014',103)
begin
/*
delete from deviceData where swipedate=convert(datetime,@attndate,103) and devicetype='tsg350'

delete from devicedata
insert devicedata(empid,cardno,swipedate,swipetime,deviceNo,swipedatestr,swipetimestr,deviceType,comid)
SELECT '0',EventUserID,convert(datetime,EventDate,103),convert(datetime,EventTime,108),EventPlace,'','','TSG350','1'
FROM OPENDATASOURCE('Microsoft.Jet.OLEDB.4.0','Data Source="C:\KEICO\PLA-SF\Database\Database.mdb"')...history
where convert(datetime,EventDate,103)=convert(datetime,'17/09/2013',103)

*/


insert manedit (empAutoNo,empid,attndate,i,o,ismanualtype,rmk,manualRmk)
select empautoNo,empid,attndate,i,o,ismanualtype,
convert(varchar,empautoNo)+empid+convert(varchar,attndate,103)+ convert(varchar,isnull(i,convert(datetime,'00:00:00',108)),108) 
+convert(varchar,isnull(o,convert(datetime,'00:00:00',108)),108) +ismanualtype,manualRmk
 from dailyattn where ismanualtype<>'' and convert(varchar,empautoNo)+empid+convert(varchar,attndate,103)+ convert(varchar,isnull(i,convert(datetime,'00:00:00',108)),108) 
+convert(varchar,isnull(o,convert(datetime,'00:00:00',108)),108) +ismanualtype not in (select rmk from manedit)

delete from deviceData where swipedate=convert(datetime,@attndate,103)

--insert devicedata(empid,cardno,swipedate,swipetime,deviceNo,swipedatestr,swipetimestr,deviceType,comid)


insert devicedata(cardno,deviceNo,swipedatestr,swipetimestr)
SELECT RMS_A.DBO.DATA_CARD.CARD_NO,RMS_A.DBO.DATA_CARD.NODE_NO,
SUBSTRING(RMS_A.DBO.DATA_CARD.D_CARD,7,2) +'/' + SUBSTRING(RMS_A.DBO.DATA_CARD.D_CARD,5,2) + '/' + SUBSTRING(RMS_A.DBO.DATA_CARD.D_CARD,1,4),
SUBSTRING(RMS_A.DBO.DATA_CARD.T_CARD,1,2) +':' + SUBSTRING(RMS_A.DBO.DATA_CARD.T_CARD,3,2) + ':' + SUBSTRING(RMS_A.DBO.DATA_CARD.T_CARD,5,2) 
FROM RMS_A.DBO.DATA_CARD WHERE RMS_A.DBO.DATA_CARD.D_CARD=@AttnDateRms


update devicedata set devicedata.empid=employee.empid,devicedata.empAutoNo=employee.empAutoNo,deviceData.comid=employee.comid
,deviceData.swipedate=convert(datetime,swipedateStr,103),deviceData.swipeTime=convert(datetime,swipeTimeStr,108)
 from employee where devicedata.cardno=employee.cardno and devicedata.swipeDateStr=@AttnDate



delete from dailyattn where attndate=convert(datetime,@attndate,103)

insert dailyattn (empAutoNo,empid,cardno,attndate,deviceIn,deviceOut,i,o,ib,ob,comid) 
select empAutoNo,empid,cardno,SwipeDate,min(swipetime),max(swipeTime),min(swipetime),max(swipeTime),min(swipetime),max(swipeTime),comid
from deviceData where swipedate= convert(datetime,@AttnDate,103) and empAutoNo in (select empAutoNo from employee) group by EmpAutoNO,empid,cardno,SwipeDate,comid

/*

--For Flora
insert dailyattn (empAutoNo,empid,cardno,attndate,deviceIn,deviceOut,i,o,ib,ob,comid,status) 
select empAutoNo,empid,'' as cardno,SwipeDate,min(swipetime),max(swipeTime),min(swipetime),max(swipeTime),min(swipetime),max(swipeTime),'1','P'
from deviceData where empAutoNo in (select empAutoNo from employee) and swipedate=convert(datetime,@AttnDate,103)
and empautono>0 group by EmpAutoNO,empid,cardno,SwipeDate
*/


update employee set terminationdate=null where year(terminationdate)=1900

delete from DAForFastPull 
insert DAForFastPull (empAutoNo) select EmpAutoNo from dailyattn where attndate=convert(datetime,@AttnDate,103) 

insert dailyattn (comid,empid,attndate,EmpAutoNo) select comid,empid,convert(datetime,@AttnDate,103),EmpAutoNo  from employee where joindate<=convert(datetime,@AttnDate,103) and 
isnull(terminationdate,convert(datetime,'01/01/2200',103)) >=convert(datetime,@AttnDate,103) and EmpAutoNO not in (select empAutoNo from DAForFastPull)


update dailyattn set dailyattn.i=m.i,dailyattn.o=m.o,dailyattn.ismanualtype=m.ismanualtype,dailyAttn.manualRmk=m.manualRmk
 from manedit m where dailyattn.attndate=m.attndate
and dailyattn.empAutono=m.empAutoNo and dailyattn.attndate=convert(datetime,@attndate,103)


update dailyattn set ib=i,ob=o where attndate=convert(datetime,@AttnDate,103)



--delete from deviceData where empid in (select Empid from employee where Active=0)
--delete from dailyattn where empid in (select Empid from employee where Active=0)


end








GO
/****** Object:  StoredProcedure [dbo].[SpInsertCur]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO






CREATE PROCEDURE [dbo].[SpInsertCur] @comId varchar(20)
as
delete from currency where comid=@comid

insert into currency (curName,comid) values ('BDT',@comid)
insert into currency (curName,comid) values ('USD',@comid)
insert into currency (curName,comid) values ('Pound',@comid)
insert into currency (curName,comid) values ('Euro',@comid)
insert into currency (curName,comid) values ('Dinner',@comid)
insert into currency (curName,comid) values ('Real',@comid)







GO
/****** Object:  StoredProcedure [dbo].[SpInsertDateForIndUpdate]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO







CREATE PROCEDURE [dbo].[SpInsertDateForIndUpdate] @AttnDate varchar(10) ,@comid varchar(10),@EmpId varchar(20)
,@intime varchar(10),@Outtime varchar(10)
AS

declare @empAutoNo numeric

select @empAutoNo=empautono from employee where empid=@empid and comid=@comid
update employee set terminationdate=null where year(terminationdate)=1900

delete from dailyattn where attndate= convert(datetime,@AttnDate,103) and empid=@empid
--insert DAForFastPull (empAutoNo) select EmpAutoNo from dailyattn where attndate=convert(datetime,@AttnDate,103) and empautoNo=@empAutoNO


insert dailyattn (comid,empid,attndate,EmpAutoNo,i,o,status)
select comid,empid,convert(datetime,@AttnDate,103),EmpAutoNo,convert(datetime,@intime,108),convert(datetime,@outtime,108),'P'
  from employee where joindate<=convert(datetime,@AttnDate,103) and 
isnull(terminationdate,convert(datetime,'01/01/2200',103)) >=convert(datetime,@AttnDate,103) and empautono=@empautono







GO
/****** Object:  StoredProcedure [dbo].[SpInsertInDailyAttn]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO













CREATE PROCEDURE [dbo].[SpInsertInDailyAttn] @attnDate Varchar(10)

AS
delete from daForFastPull
insert daForFastPull (empid,attndate) select empid,attndate from dailyattn where attndate=convert(datetime,@attndate,103)

insert  dailyattn(Empid,Attndate,Absentqty) select empid,convert(datetime,@attndate,103),1 from employee 
where isnull(Terminationdate,convert(datetime,'01/01/2200',103)) >= convert(datetime,@attndate,103) and 
Joindate <=convert(datetime,@attndate,103) and empid not in (select empid from daForFastPull)













GO
/****** Object:  StoredProcedure [dbo].[SpInsertMstrData]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO




--exec SpInsertMstrData 'RAFI-PC', 'Demo Company', '01843885002'


CREATE   PROCEDURE [dbo].[SpInsertMstrData] @PCName varchar(30),@CompanyName varchar(100),@phone varchar(100)
 AS

declare @DataIsPresent int,@ComId varchar(10),@TypeId int,@userCode int

set @comid='0'

select @comid=isnull(comid,'0') from branch where name=@companyName

--select @DataIsPresent=isnull(count(username),0) from loginuser where comid = @comid
--SET @dataIsPresent=0

if @COMID='0'
begin

select @comid=isnull(max(convert(int,comid)),0)+1 from branch

INSERT INTO BRANCH (COMID,NAME,pcname,phone) VALUES (@comid,@CompanyName,@pcname,@phone)
INSERT INTO LOGINUSER (USERNAME,PASSWORD,comid) VALUES('rafi','rafi@123',@comid)
--SELECT * FROM LOGINUSER

select @usercode=usercode from loginuser where username='rafi' and comid=@comid

INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'BRANCH',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'SECURITY',1,1,1,1,@comid)
--INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'CHANGE PASSWORD',1,1,1,1)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'USER CREATION',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'BACKUP DATABASE',1,1,1,1,@comid)
--INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'QUERY ANALYZER',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'HEAD CREATION',1,1,1,1,@comid)
--INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'CONNECT TO SERVER',1,1,1,1,@comid)


INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'PARTY INFORMATION',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'ITEM INFORMATION',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'PURCHASE INFORMATION',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'SALE INFORMATION',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'REPORT',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'ACCOUNTS VOUCHER',1,1,1,1,@comid)

--INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'SETTING',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'EMPLOYEE INFORMATION',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'DAILY ATTENDANCE',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'SALARY ENTRY',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'SALARY SHEET PROCESS',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'LEAVE ENTRY',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'BONUS',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'MASTER INFO',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'EARN LEAVE',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'GLOBAL SETUP',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'ADVANCE',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'PF',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'SECTION',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'PROCESS BLOCK',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'DOLLER RATE ENTRY',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'LINE',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'DESIGNATION',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'GRADE',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'CABINATE INFO',1,1,1,1,@comid)
--INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'BRANCH',1,1,1,1)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'INITIAL INFO',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'RESPONSIBILITY INFO',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'FAMILY INFO',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'EMPLOYEE EDUCATION',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'EMPLOYEE EXPIRIENCE',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'CARD PERSONALIZATION FO RMS',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'MONTHLY ATTENDANCE',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'HOLIDAY ASSIGN',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'INCOME TAX',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'PRODUCTION BONUS',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'OTHERS ALLOWANCE',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'HR REPORT',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'MONTHLY SALARY',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'ID CARD',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'ACTIVITIES INFO ',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'EMPLOYEE DETAILS BANGLA ',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'SHIFTING TIME SETUP ',1,1,1,1,@comid)
--INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'SECURITY',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'CHANGE PASSWORD',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'REPORT FOR EXCEL',1,1,1,1,@comid)
--INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'USER CREATION',1,1,1,1,@comid)
--INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'BACKUP DATABASE',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'QUERY ANALYZER',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'HEDING',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'CONNECT TO SERVER',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'OT UPDATE',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'SCAN INFO',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'PULL DATA',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'SALARY INCREMENT',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'DEPARTMENT INFORMATION',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'BILL COLLECTION',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'COMPLAINT REGISTER',1,1,1,1,@comid)


INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'INVOICE',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'VOUCHER',1,1,1,1,@comid)

INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'TEST COST EDIT',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'VOUCHER ENTRY',1,1,1,1,@comid)
INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'VOUCHER EDIT',1,1,1,1,@comid)
--select * from security



--SELECT * FROM BRANCH
--select * from setting

insert setting (pcname,salarystyle,comid) select host_name(),'BGMEA',@comid

--SELECT * FROM PARTYINFO
--select * from Head
insert into partyinfo (partycode,partyname,partytype,accthead,comid,Master) values ('1','Cash Purchase','Supplier','Cash Purchase',@comid,'Master')
insert into head (headname,type,Master,comid) values ('','Expense','Master',@comid)
insert into head (headname,type,Source,comid,HGroup,Master) values ('Cash Purchase','Purchase','Party-1',@comid,'Purchase','Master')

insert into partyinfo (partycode,partyname,partytype,accthead,comid,Master) values ('2','Cash Sale','Customer','Cash Sale',@comid,'Master')
insert into head (headname,type,Source,comid,HGroup,Master) values ('Cash Sale','Sales','Party-2',@comid,'Sales','Master')

/*
insert into partyinfo (partycode,partyname,partytype,accthead,comid,Master) values ('3','Cash Purchase','Supplier','Cash Purchase',@comid,'Master')
insert into head (headname,type,Source,comid,HGroup,Master) values ('Cash Purchase','Purchase','Party-3',@comid,'Purchase','Master')

insert into partyinfo (partycode,partyname,partytype,accthead,comid,Master) values ('4','Cash Sale','Customer','Cash Sale',@comid,'Master')
insert into head (headname,type,Source,comid,HGroup,Master) values ('Sales','Cash Sale','Party-4',@comid,'Sales','Master')
*/

insert into head (headname,type,Source,comid,HGroup,Master) values ('Purchase','Purchase','Purchase',@comid,'Purchase','Master')
insert into head (headname,type,Source,comid,HGroup,Master) values ('Sales','Sales','Sales',@comid,'Sales','Master')

insert into head (headname,type,Source,comid,HGroup,Master) values ('Conveyance','Expense','Expense',@comid,'Expense','Master')
insert into head (headname,type,Source,comid,HGroup,Master) values ('Office Rent','Expense','Expense',@comid,'Expense','Master')
insert into head (headname,type,Source,comid,HGroup,Master) values ('Electric Bill','Expense','Expense',@comid,'Expense','Master')
insert into head (headname,type,Source,comid,HGroup,Master) values ('Staff Salary','Expense','Expense',@comid,'Expense','Master')
insert into head (headname,type,Source,comid,HGroup,Master) values ('Gas Bill','Expense','Expense',@comid,'Expense','Master')
insert into head (headname,type,Source,comid,HGroup,Master) values ('Office Expense','Expense','Expense',@comid,'Expense','Master')
insert into head (headname,type,Source,comid,HGroup,Master) values ('Miscellanious','Expense','Expense',@comid,'Expense','Master')
insert into head (headname,type,Source,comid,HGroup,Master) values ('Entertainment','Expense','Expense',@comid,'Expense','Master')
insert into head (headname,type,Source,comid,HGroup,Master) values ('Others Expenses','Expense','Expense',@comid,'Expense','Master')
--insert into head (headname,type,Source,comid,HGroup,Master) values ('Loan Interest','Expense','Expense','1','Expense','Master')
--insert into head (headname,type,Source,comid,HGroup,Master) values ('Furniture and Fixtures','Asset','Asset','1','Asset')
insert into head (headname,type,Source,comid,HGroup,Master) values ('Furniture and Fixtures','Furniture & Fixtures','Asset',@comid,'Asset','Master')
insert into head (headname,type,Source,comid,HGroup,Master) values ('Capital','Capital','Liabilities',@comid,'Liabilities','Master')
insert into head (headname,type,Source,comid,HGroup,Master) values ('Cash In Hand','Cash In Hand','Asset',@comid,'Asset','Master')
insert into head (headname,type,Source,comid,HGroup,Master) values ('Bank','Bank A/C (Current)','Asset',@comid,'Asset','Master')


insert into SettingSingle (vatPerc,comid) values(0,@comid)
--SELECT * FROM TB
select @typeId=isnull(max(typeid),100)+1 from acctType
insert into accttype (typeid,type,destination,comid) values (@typeId+1,'Bank A/C (Savings)','Current Asset',@comid)
insert into accttype (typeid,type,destination,comid) values (@typeId+2,'Bank A/C (Current)','Current Asset',@comid)
insert into accttype (typeid,type,destination,comid) values (@typeId+3,'Capital','Capital',@comid)
insert into accttype (typeid,type,destination,comid) values (@typeId+4,'Cash In Hand','Current Asset',@comid)
insert into accttype (typeid,type,destination,comid) values (@typeId+5,'Clock','Current Asset',@comid)
insert into accttype (typeid,type,destination,comid) values (@typeId+6,'Current Asset','Current Asset',@comid)
insert into accttype (typeid,type,destination,comid) values (@typeId+7,'Direct Expense','Trading A/C Expense',@comid)
insert into accttype (typeid,type,destination,comid) values (@typeId+8,'Fixed Asset','Fixed Asset',@comid)
insert into accttype (typeid,type,destination,comid) values (@typeId+9,'Indirect Expense','PL A/C Expense',@comid)
insert into accttype (typeid,type,destination,comid) values (@typeId+10,'Expense','PL A/C Expense',@comid)
insert into accttype (typeid,type,destination,comid) values (@typeId+11,'Intrangible Asset','Fixed Asset',@comid)
insert into accttype (typeid,type,destination,comid) values (@typeId+12,'Loan','Loan Payable/Receivable',@comid)
insert into accttype (typeid,type,destination,comid) values (@typeId+13,'Others Asset','Others Asset',@comid)
insert into accttype (typeid,type,destination,comid) values (@typeId+14,'Others Liabilities','Others Liabilities',@comid)
insert into accttype (typeid,type,destination,comid) values (@typeId+15,'Party','Accounts Payable/Receivable',@comid)
insert into accttype (typeid,type,destination,comid) values (@typeId+16,'Purchase','Trading A/C Expense',@comid)
insert into accttype (typeid,type,destination,comid) values (@typeId+17,'Revenue','Trading A/C Income',@comid)
insert into accttype (typeid,type,destination,comid) values (@typeId+18,'Sales','Trading A/C Income',@comid)
insert into accttype (typeid,type,destination,comid) values (@typeId+19,'Furniture & Fixtures','Fixed Asset',@comid)
insert into accttype (typeid,type,destination,comid) values (@typeId+20,'Bank A/C (Loan)','Current Liabilities',@comid)


insert sectiontbl(codeno,name,comid) values (0,'NA',@comid)
insert line(codeno,name,comid) values (0,'NA',@comid)
insert department(codeno,name,comid) values (0,'NA',@comid)
insert designation(codeno,name,comid) values (0,'NA',@comid)
insert grade(codeno,name,comid) values (0,'NA',@comid)

insert into salstyle (style,basic,hrent,medical) values ('BEPZA',60,30,10)
insert into salstyle (style,basic,hrent,medical) values ('BGMEA',0,40,1100)
insert into salstyle (style,basic,hrent,medical) values ('BKMEA',0,0,0)

update settingsingle set salarystyle='BGMEA' where comid=@comid

Insert Into LoginUser (UserName,Password,ComID)Values('bijoy','bijoy@123',@comid)
Insert Into LoginUser (UserName,Password,ComID)Values('jomir','jomir@123',@comid)
Insert Into LoginUser (UserName,Password,ComID)Values('leon','leonxeon',@comid)

INSERT INTO TIMEGROUP (GROUPID,INTIME,OUTTIME,MAXINTIME,SETUPDATE,OTSTART,MAXOT,comid)
VALUES ('GENERAL',CONVERT(DATETIME,'08:00:00',108),CONVERT(DATETIME,'17:00:00',108),CONVERT(DATETIME,'08:10:00',108)
,CONVERT(DATETIME,'01/01/2013',103),CONVERT(DATETIME,'17:00:00',108),2,@comid)

insert itemunit (unitid,unitname,comid) values ('Pcs','Pcs',@comid)
insert itemunit (unitid,unitname,comid) values ('Dzn','Dzn',@comid)
insert itemunit (unitid,unitname,comid) values ('Kg','Kg',@comid)
insert itemunit (unitid,unitname,comid) values ('Time(s)','Time(s)',@comid)
--insert into voucherMstr(VoucherNo,AutoRmk,ComID,vdate) values ('0','All Opening Balance','1',convert(datetime,'01/01/1900')

update AcctType set Destination='Cash In Hand' where type in ('Cash','Cash In Hand','Petty Cash')
update AcctType set Destination='Cash at Bank' where type in ('Bank A/C (Current)','Bank A/C (Savings)')

end



GO
/****** Object:  StoredProcedure [dbo].[SpJournalEntrySave]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO






CREATE PROCEDURE [dbo].[SpJournalEntrySave] @AutoNoFromMstrTbl money,@VDate varchar(10),@pcName varchar(100)

 AS

if isdate(@vdate)=1
begin
update voucherMstr set vdate=convert(datetime,@VDate,103),pcname=@pcName where autono=@AutoNoFromMstrTbl
end

delete from voucher where AutoNoFromMstrTbl=@AutoNoFromMstrTbl

insert voucher (AutoNoFromMstrTbl,VoucherNo,HeadId,Dr,Cr,Note,ComId,Amount,PCName,UserCode,d_c)
select AutoNoFromMstrTbl,VNo,HeadId,Dr,Cr,Note,ComId,dr+cr,PCName,UserCode,d_c from temVoucher where AutoNoFromMstrTbl=@AutoNoFromMstrTbl






GO
/****** Object:  StoredProcedure [dbo].[SpLeave]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO








CREATE Procedure [dbo].[SpLeave] @ForYear varchar(10),@CL money,@sL money,@EL money,@comid varchar(10)
As

Declare @EmpID varchar(10),@MonthNo money,@JoinYear int,@CLAVL Money,@SLAVL Money,@ELAVL Money
,@empAutoNo money,@joindate datetime,@CLFxd money,@sLFxd money,@ELFxd money


--set @comid='1'

DELETE FROM LeaveBalance WHERE  FORYEAR=@FORYEAR and comid=@comid
delete from errtbl

	Declare CurBonusEid Cursor
	Forward_only
	Keyset
	Scroll_locks
	For
	Select empAutoNo,EmpID,year(joindate),13-month(joindate),ComId,joindate
	from Employee where Active=1 and year(JoinDate)<=@ForYear  and comid=@comid --and empid='4985'
	
	Open curBonusEid
	Fetch next from curBonusEid into @empAutoNo,@EmpID,@JoinYear,@MonthNo,@ComId,@joindate

	while @@Fetch_Status=0
	Begin



set @CLAVL =0  set @SLAVL =0  set @ELAVL =0 
set @clFxd=@CL
set @slFxd=@SL
set @elFxd=@EL

if year(@joindate)<convert(int,@forYear)
begin
set @MonthNo=12
end



if @JoinYear=convert(int,@forYear)
begin
SET  @CLFxd = round((@CL / 12) * @MonthNo,0)
SET  @SLFxd = round((@SL / 12) * @MonthNo,0)
SET  @ELFxd = round((@EL / 12) * @MonthNo,0)
end


Select @CLAVL=isnull(sum(lqty),0) from leave where typeofleave='CL' and year(leavedate)= @ForYear and empid=@EmpID and comid=@ComId and halfqty=0
Select @SLAVL=isnull(sum(lqty),0) from leave where typeofleave='SL' and year(leavedate)= @ForYear and empid=@EmpID and comid=@ComId and halfqty=0
Select @ELAVL=isnull(sum(lqty),0) from leave where typeofleave='EL' and year(leavedate)= @ForYear and empid=@EmpID and comid=@ComId and halfqty=0

       

Insert into LeaveBalance (ForYear,EmpID,CLFixed,SLFixed,ELFixed,CLAVL,SLAVL,ELAVL,CLBal,SLBal,ELBal,ComId,empAutoNo)
values(@ForYear,@EmpID,isnull(@CLFxd,0),isnull(@SLFxd,0),isnull(@ELFxd,0),isnull(@CLAVL,0),isnull(@SLAVL,0),isnull(@ELAVL,0),
(isnull(@CLFxd,0)-isnull(@CLAVL,0)),(isnull(@SLFxd,0)-isnull(@SLAVL,0)),(isnull(@ELFxd,0)-isnull(@ELAVL,0)),@ComId,@empAutoNo)


Fetch next from curBonusEid into @empAutoNo,@EmpID,@JoinYear,@MonthNo,@ComId,@joindate



		if @@Error <> 0  
		Begin
		Rollback Transaction
		Raiserror('Insertion Failed',16,1)
		Return -1
		End	
end
deallocate CurBonusEid







GO
/****** Object:  StoredProcedure [dbo].[SPLeaveProcess]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO











CREATE PROCEDURE [dbo].[SPLeaveProcess]
@ForMonthno int, @Foryear varchar(4),@comid varchar(10)
As


Declare  @Empid varchar(20),@Leavedate datetime,@TypeOfLeave varchar(5),@LeaveQty int



	Declare curSAL Cursor
	Forward_Only
	Keyset
	Scroll_locks
For


Select empid,leavedate,typeofleave from leave where month(leavedate)=@forMonthNo and Year(leaveDate)=@foryear  and comid=@comid
	Open curSAL
	Fetch  from curSAL into @Empid,@Leavedate,@TypeOfLeave
	while @@Fetch_Status=0
	
	BEGIN




             set @LeaveQty=1
            
             update dailyattn SET LeaveRmk=@TypeOfLeave,LeaveQty=@LeaveQty  WHERE attnDATE=CONVERT(DATETIME,@Leavedate,103) AND EMPID=@Empid and comid=@comid
         

	Fetch  from curSAL into @Empid,@Leavedate,@TypeOfLeave

if @@Error <> 0
		Begin
		Rollback Transaction
		Raiserror('Insertion Failed',16,1)
		Return -1
		End	
	End
Deallocate curSAL









GO
/****** Object:  StoredProcedure [dbo].[SpLeaveSingle]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO

















CREATE Procedure [dbo].[SpLeaveSingle] @empAutoNo money,@ForYear varchar(10)
As

Declare @EmpID varchar(10),@MonthNo money,@JoinYear varchar(10),@ComId varchar(10), @CLAVL Money,@SLAVL Money,@ELAVL Money
,@joindate datetime,@CL Money,@SL Money ,@EL Money


DELETE FROM LeaveBalance WHERE  FORYEAR=@FORYEAR and empautono=@empAutono

	Declare CurBonusEid Cursor
	Forward_only
	Keyset
	Scroll_locks
	For
	Select empAutoNo,EmpID,year(joindate),13-month(joindate),ComId,joindate
	from Employee where Active=1 and year(JoinDate)<=@ForYear and empautono=@empAutono
	
	Open curBonusEid
	Fetch next from curBonusEid into @empAutoNo,@EmpID,@JoinYear,@MonthNo,@ComId,@joindate

	while @@Fetch_Status=0
	Begin

	           set @CLAVL =0  set @SLAVL =0  set @ELAVL =0 
		set @CL =10  set @SL =14  set @EL =17 

if year(@joindate)<@forYear
begin
set @MonthNo=12
end

if @JoinYear=@ForYear
begin
SET  @CL =(@CL / 12) * @MonthNo
SET  @SL = (@SL / 12) * @MonthNo
SET  @EL = (@EL / 12) * @MonthNo
end

Select @CLAVL=isnull(sum(lqty),0) from leave where typeofleave='CL' and year(leavedate)= @ForYear and empAutoNO=@EmpAutoNO
Select @SLAVL=isnull(sum(lqty),0) from leave where typeofleave='SL' and year(leavedate)= @ForYear and empAutoNO=@EmpAutoNO
Select @ELAVL=isnull(sum(lqty),0) from leave where typeofleave='EL' and year(leavedate)= @ForYear and empAutoNO=@EmpAutoNO

                                              

Insert into LeaveBalance (ForYear,EmpID,CLFixed,SLFixed,ELFixed,CLAVL,SLAVL,ELAVL,CLBal,SLBal,ELBal,ComId,empAutoNo)
values(@ForYear,@EmpID,isnull(@CL,0),isnull(@SL,0),isnull(@EL,0),isnull(@CLAVL,0),isnull(@SLAVL,0),isnull(@ELAVL,0),
(isnull(@CL,0)-isnull(@CLAVL,0)),(isnull(@SL,0)-isnull(@SLAVL,0)),(isnull(@EL,0)-isnull(@ELAVL,0)),@ComId,@empAutoNo)


Fetch next from curBonusEid into @empAutoNo,@EmpID,@JoinYear,@MonthNo,@ComId,@joindate



		if @@Error <> 0  
		Begin
		Rollback Transaction
		Raiserror('Insertion Failed',16,1)
		Return -1
		End	
end
deallocate CurBonusEid















GO
/****** Object:  StoredProcedure [dbo].[spLogFile]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO











CREATE PROCEDURE [dbo].[spLogFile]
AS
BACKUP LOG [everest] WITH TRUNCATE_ONLY
DBCC SHRINKFILE (everest_log, 1)







GO
/****** Object:  StoredProcedure [dbo].[SPMaleFemale]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO










CREATE PROCEDURE [dbo].[SPMaleFemale]
@forMonthNo int, @forYear int,@comid varchar(10)
AS


update dailyattn set male=1,female=0,femalep=0,femalea=0 where  MONTH(ATTNDATE)=@forMonthNo AND YEAR(ATTNDATE)=@forYear and comid=@comid
and empid in (select empid from employee where sex='male')

update dailyattn set male=0,female=1,malea=0,malep=0 where  MONTH(ATTNDATE)=@forMonthNo AND YEAR(ATTNDATE)=@forYear and comid=@comid
and  empid in (select empid from employee where sex<>'male')

update dailyattn set malep=1,malea=0,femalep=0,femalea=0 where presentqty=1 and 
 MONTH(ATTNDATE)=@forMonthNo AND YEAR(ATTNDATE)=@forYear and comid=@comid and  empid in (select empid from employee where sex='male')

update dailyattn set femalep=1,femalea=0, malep=0,malea=0 where presentqty=1 and   MONTH(ATTNDATE)=@forMonthNo AND YEAR(ATTNDATE)=@forYear and comid=@comid
and empid in (select empid from employee where sex<>'male')

update dailyattn set malep=0,femalep=0,malea=1 where holidayqty=1 and 
 MONTH(ATTNDATE)=@forMonthNo AND YEAR(ATTNDATE)=@forYear and comid=@comid and 
empid in (select empid from employee where sex='male')


update dailyattn set malep=0,femalep=0,femalea=1 where holidayqty=1 and 
 MONTH(ATTNDATE)=@forMonthNo AND YEAR(ATTNDATE)=@forYear and comid=@comid and 
empid in (select empid from employee where sex='female')







GO
/****** Object:  StoredProcedure [dbo].[SPMonSalary]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO















CREATE PROCEDURE [dbo].[SPMonSalary]
	 @ForMonth varchar(9)
	,@ForYear int
	,@FormonthNo int
	,@ForMonthsDay int
,@comid varchar(10)

As

exec SpAdvProcess @ForMOnthNo,@ForYear

delete from Monsalary where formonth =@ForMonth and foryear =@ForYear  and comid=@comid
exec SpSalProcessFromDailyAttn @ForMonth,@ForYear,@ForMOnthNo,@ForMonthsDay,@comid

delete from Monsalary where formonth =@ForMonth and foryear =@ForYear   and comid=@comid
and empAutoNo in (select empautono from monthlyAttn where formonth=@formonth and foryear=@forYear and TotAttnday>0 and comid=@comid)

exec SpSalProcessFromMonthlyAttn @ForMonth,@ForYear,@ForMOnthNo,@ForMonthsDay,@comid








GO
/****** Object:  StoredProcedure [dbo].[SpNewSecurity]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO










CREATE Procedure [dbo].[SpNewSecurity] @ScreenName varchar(100)
As

declare @userCode int,@comid varchar(20)
delete from security where screen=@screenname



Declare curAdv Cursor
	Forward_only
	Keyset
	Scroll_locks
For
	Select usercode,comid from loginuser
Open curAdv
Fetch from curAdv into @usercode,@comid
while @@Fetch_Status=0
Begin


insert into security (UserCode,SCREEN,S,E,V,D,ComId) values(@usercode,@screenName,1,1,1,1,@comid)
--INSERT INTO SECURITY (UserCode,SCREEN,S,E,V,D,ComId) VALUES(@userCode,'HEAD CREATION',1,1,1,1,@comid)

Fetch from curAdv into @usercode,@comid
	
End
Deallocate curAdv









GO
/****** Object:  StoredProcedure [dbo].[SpOTUpdate]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO

























CREATE PROCEDURE [dbo].[SpOTUpdate]
@forMonthNo int, @forYear int
AS


update dailyattn set presentqty=0,absentqty=0,leaveqty=0,holidayqty=0,Status='A',otHr=0,otmnt=0,ot=0  WHERE MONTH(ATTNDATE)=@forMonthNo AND YEAR(ATTNDATE)=@forYear 

exec SpDailyAttnLeaveUpdate @FormonthNo,@ForYear
exec SpHolidayGeneralUpdate @FormonthNo,@ForYear
exec SPLeaveProcess @FormonthNo,@ForYear
exec SpShiftUpdate @FormonthNo,@ForYear

update dailyattn set presentqty=1,absentqty=0,Status='P'  WHERE MONTH(ATTNDATE)=@forMonthNo AND YEAR(ATTNDATE)=@forYear and 
(isnull(i,convert(datetime,'00:00:00',108))>convert(datetime,'00:00:00',108) or isnull(o,convert(datetime,'00:00:00',108))>convert(datetime,'00:00:00',108))

update dailyattn set absentqty =1 where Status ='A' and  LeaveQty =0 and HolidayQty =0  and MONTH(ATTNDATE)=@forMonthNo and YEAR(ATTNDATE)=@forYear

update dailyattn set late='Late',lateqty=1 where MONTH(attndate)=@FORMONTHNO and year(attndate)=@FORYEAR and i>maxintime

update dailyattn set holidayWork=1 where isnull(holidayqty,0)=1 and presentqty=1 and month(attndate)=@forMOnthno and year(attndate)=@foryear

update dailyattn set otstart=dateadd(dd,-1,otstart) where MONTH(attndate)=@FORMONTHNO and year(attndate)=@FORYEAR
 and o>convert(datetime,'00:00:00',103) and o<convert(datetime,'04:00:00',103)

update dailyattn set ib=i,ob=o,otb=ot where MONTH(attndate)=@FORMONTHNO and year(attndate)=@FORYEAR

update dailyattn set otmnt=isnull(datediff(n,otstart,o),0) where MONTH(attndate)=@FORMONTHNO and year(attndate)=@FORYEAR
update dailyattn set ot=floor(otmnt/60),othr=floor(otmnt/60) where MONTH(attndate)=@FORMONTHNO and year(attndate)=@FORYEAR
update dailyattn set otmnt=otmnt-(othr*60) where MONTH(attndate)=@FORMONTHNO and year(attndate)=@FORYEAR
update dailyattn set ot=ot+1 where otmnt>=40 and MONTH(attndate)=@FORMONTHNO and year(attndate)=@FORYEAR

update dailyattn set ob=dateadd(hh,maxot,otstart),otb=maxot where ot>maxot and
 MONTH(attndate)=@FORMONTHNO and year(attndate)=@FORYEAR and holidayqty=0

update dailyattn set ob=dateadd(n,convert(money,substring(convert(varchar,i,108),5,1)),ob) where month(attndate)=@formonthNo and year(attndate)=@foryear and ob=dateadd(hh,maxot,otstart)
update dailyattn set ob=dateadd(ss,datepart(ss,o),ob) where month(attndate)=@forMonthNo and year(attndate)=@foryear and datepart(ss,ob)=0 and  ob>dateadd(hh,maxot,otstart)


update dailyattn set male=1,female=0 where empid in (select empid from employee where sex='male')
update dailyattn set male=0,female=1 where empid in (select empid from employee where sex<>'male')
update dailyattn set malep=1,malea=0 where presentqty=1 and  empid in (select empid from employee where sex='male')
update dailyattn set femalep=1,femalea=0 where presentqty=1 and  empid in (select empid from employee where sex<>'male')


update dailyattn set othr=0,othrb=0,ot=0,otb=0,otmnt=0,otmntb=0
 where  month(attndate)=@forMonthNO and year(attndate)=@foryear and 
empid in (select empid from employee where overtime=0)

update dailyattn set i=null where i=convert(datetime,'00:00:00',108) and month(attndate)=@FORMONTHNO and year(attndate)=@foryear
update dailyattn set ib=null where ib=convert(datetime,'00:00:00',108) and month(attndate)=@FORMONTHNO and year(attndate)=@foryear
update dailyattn set o=null where o=convert(datetime,'00:00:00',108) and month(attndate)=@FORMONTHNO and year(attndate)=@foryear
update dailyattn set ob=null where ob=convert(datetime,'00:00:00',108) and month(attndate)=@FORMONTHNO and year(attndate)=@foryear






















GO
/****** Object:  StoredProcedure [dbo].[SpPLAc]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO













CREATE PROCEDURE [dbo].[SpPLAc] @comid varchar(10),@pcName varchar(50),@FromDate varchar(10),@ToDate varchar(10),@userId varchar(50)
AS

declare @openingStock money,@closingStock money,@totExp money, @totIncome money,@profitOrLoss varchar(20)

exec SpTradeAc @comid,@pcName,@FromDate,@ToDate,@userId

set @openingStock=0
set @closingStock=0

delete from temTradAc where head not like 'gross%' and pcname=@pcname and comid=@comid

select @ProfitOrLoss=head from temTradAc where head like 'gross%' and pcname=@pcname and comid=@comid

if @profitOrLoss like 'gross prof%'
begin
update temTradAc set headamtcr=headamtdr,headamtdr=0 where head like 'gross%' and pcname=@pcname and comid=@comid and headamtDr>0
--update temTradAc set headamtdr=0 where head like 'gross%' and pcname=@pcname and comid=@comid
end

if @profitOrLoss like 'gross los%'
begin
update temTradAc set headamtdr=headamtCr,headamtCr=0 where head like 'gross%' and pcname=@pcname and comid=@comid and headamtCr>0
end

/*
insert temtradac (head,headamtDr,pcname,comid) select h.HeadName,sum(v.Dr) as DrAmt,@PCName,@comid
from voucherMstr m,voucher  v,head h where m.autoNo=v.autonofrommstrTbl and m.comid=v.comid and h.headid=v.headid and h.comid=v.comid and h.type in ('indirect Expense','indirect Expenses','expense','expenses','others expenses','other expenses','others expense')
 and m.vdate between convert(datetime,@FromDate,103) and  convert(datetime,@ToDate,103) AND m.comid=@COMID group by h.HeadName order by h.headname
*/

insert temtradac (head,headamtDr,pcname,comid) select h.HeadName,sum(v.Dr) as DrAmt,@PCName,@comid from voucherMstr m,voucher  v,head h where m.autono=v.autoNoFromMstrTbl and m.comid=v.comid and h.headid=v.headid and h.comid=v.comid 
and h.type in (select type from accttype where destination ='pl a/c expense' and comid=@comid) and m.vdate between convert(datetime,@fromDate,103) and  convert(datetime,@ToDate,103) group by h.HeadName order by h.headname

insert temtradac (head,headamtCr,pcname,comid) select h.HeadName,sum(v.Cr) as CrAmt,@PCName,@comid from voucherMstr m,voucher  v,head h where m.autono=v.autonoFromMstrTbl and m.comid=v.comid and h.comid=v.comid and h.headid=v.headid 
and h.type in (select type from accttype where destination ='pl a/c income' and comid=@comid) and v.vdate between convert(datetime,@fromDate,103) and  convert(datetime,@ToDate,103) group by h.HeadName order by h.headname



select @totExp=isnull(sum(headamtdr),0),@totIncome=isnull(sum(headamtcr),0) from temtradAc where comid=@comid and pcname=@pcName


If @totExp > @totIncome 
begin
insert into temtradac (head,headamtCr,pcname,comid) values ('Net Loss (Transfer to Capital A/C)',@totExp - @totIncome ,@PCName,@comid)
end

if @totExp < @totIncome
begin
insert into temtradac (head,headamtDr,pcname,comid) values ('Net Profit (Transfer to Capital A/C)',@totIncome - @totExp ,@PCName,@comid)
end

--update temTradAc set slno=0 where head like 'opening%' and comid=@comid and pcname=@pcname
--update temTradAc set slno=1 where head like 'Purcha%' and comid=@comid and pcname=@pcname
update temTradAc set slno=0 where head like 'gross %' and comid=@comid and pcname=@pcname
update temTradAc set slno=AutoNo where head not like 'gross %' and comid=@comid and pcname=@pcname
update temTradAc set type='Trade' where comid=@comid and pcname=@pcname
--delete from temTradAc where pcname=@pcname and comid=@comid and headamtDr=0 and headamtCr=0













GO
/****** Object:  StoredProcedure [dbo].[SpRandom]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO














CREATE PROCEDURE [dbo].[SpRandom]
	@FormonthNo int
	,@ForYear int
as

	--declare variable part start 
declare @EmpAutoNo money,@EmpId varchar(20),@ComId varchar(10),@AdvCode varchar(100),@Balance money,@instAmt money,@attndate datetime


	Declare curSalary Cursor
	Forward_Only
	Keyset
	Scroll_locks
	For
   	------- select qry the main qry-------
select empAutoNo,attndate from dailyattn where month(attndate)=@forMonthNo and year(attndate)=@forYear and (i=convert(datetime,'08:00:00',108) or i=convert(datetime,'20:00:00',108))
	Open curSalary-----Loop strat

	Fetch Next from curSalary into @empAutoNo,@attndate
	while @@Fetch_Status=0
	
	Begin

update dailyattn set i=dateadd(ss,1+floor(58*RAND()),dateadd(n,1+CONVERT(INT, (-10+1)*RAND()),i)) where empautono=@empAutoNo and attndate=convert(datetime,@attndate,103)                
update dailyattn set o=dateadd(ss,1+floor(58*RAND()),dateadd(n,1+CONVERT(INT, (10+1)*RAND()),o)) where empautono=@empAutoNo and attndate=convert(datetime,@attndate,103)                
               
	Fetch Next from curSalary into @empAutoNo,@attndate

if @@Error <> 0
		Begin
		Rollback Transaction
		Raiserror('Insertion Failed',16,1)
		Return -1
		End	
	End
Deallocate cursalary-----loop end








GO
/****** Object:  StoredProcedure [dbo].[SpSalaryUpdate]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO















CREATE PROCEDURE [dbo].[SpSalaryUpdate] @empAutoNo int,@Gross money,@PrevDesgCode int,@PresDesgCode int
 AS

Declare @salaryStyle varchar(100)

select @salaryStyle =salaryStyle from settingSingle

if @empAutoNo>0 
begin
	if @salaryStyle='BGMEA'
	begin
	update employee set gross=@Gross,medical=200,hrent=((@Gross-200)/1.4)*0.4,basic=(@Gross-200)/1.4 where empautono=@empautono
	end

	if @salaryStyle='BEPZA'
	begin
	update employee set gross=@Gross,medical=@Gross*0.1,hrent=@Gross*0.3,basic=@Gross*0.6 where empautono=@empautono
	end

	if @PrevDesgCode <>@PresDesgCode
	begin
	update employee set designationCode=@PresDesgCode where empautono=@empautono
	end
end

if @empAutoNo=0
begin
	IF @salaryStyle='BGMEA'
	BEGIN
	update employee set medical=200,hrent=((gross-200)/1.4)*0.4,basic=(gross-200)/1.4 
	END
	
	IF @salaryStyle='BEPZA'
	BEGIN
	update employee set gross=@Gross,medical=@Gross*0.1,hrent=@Gross*0.3,basic=@Gross*0.6
	END
end















GO
/****** Object:  StoredProcedure [dbo].[SpSalProcessFromDailyAttn]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO











CREATE PROCEDURE [dbo].[SpSalProcessFromDailyAttn]
	 @ForMonth varchar(9)
	,@ForYear varchar(9)
	,@FormonthNo int
	,@ForMonthsDay int,@comid varchar(10)

	
As

update monthlyTbl set Bname ='Rvbyqvix' where formonth='January'
update monthlyTbl set Bname ='‡deªæqvix' where formonth='February'
update monthlyTbl set Bname ='gvP©' where formonth='March'
update monthlyTbl set Bname ='GwcÖj' where formonth='April'
update monthlyTbl set Bname ='‡g' where formonth='May'
update monthlyTbl set Bname ='Ryb' where formonth='June'
update monthlyTbl set Bname ='RyjvB' where formonth='July'
update monthlyTbl set Bname ='AvM÷' where formonth='August'
update monthlyTbl set Bname ='‡m‡Þ¤^i' where formonth='September'
update monthlyTbl set Bname ='A‡±vei' where formonth='October'
update monthlyTbl set Bname ='b‡f¤^i' where formonth='November'
update monthlyTbl set Bname ='wW‡m¤^i' where formonth='December'

DELETE FROM MONSALARY WHERE FORMONTH=@FORMONTH AND FORYEAR=@FORYEAR  and  comid=@comid
--AND EMPID IN (SELECT EMPID FROM TEMSALPROCESS)
update employee set terminationdate =null where year(terminationdate)=1900
--exec SpAdvProcess @forMonth,@forYear,@forMonthNo,@ForMonthsDay

          declare @type varchar(100),@lateDed money,@NwDay int,@nwAmt money,@transport money,@prodQty money,@prodAmt money,@Alnc money,@salType varchar(100), @EmpId varchar(10),@GrossB money ,@Gr money ,@Basic Money,@HRent Money,@Medical money,@OTHour money,@OTRate money,@OTAmt money,@ExtraOTHour money,@ExtraOTRate money,@ExtraOTAmt money,
          @AttnBonus money,@AttnDay int,@AbsDay int,@HoliDay int,@FestivalDay int,@OthersAdd money,@AdvDed money,@AbsDed money,@OthersDed money,@FDAte datetime
	    ,@TotalEarn money,@TotalDed money,@NetPay money,@JDate datetime,@HolidayWork int,@OtCheck int,@leaveWithPay int,@Workday int,@GradeID varchar(50)
                   ,@DegId varchar (10),@AttnBonCheck int,@SalaryDay money,@Stamp  money ,@LineCode varchar(50),@resigndate datetime,@NewEmp int,@Shift varchar(50)
                   ,@IncYear varchar (20),@ldate datetime,@IncAmt money,@sectionid varchar(50),@desId varchar(50),@AbsdedOrg money, @NetPayOrg money,@GrossOrg money
                   ,@CL int,@SL int,@EL int,@ML int ,@OTDed money, @TA money ,@Food money,@TotalDedOrg money,@EmpAutoNo int,@GovHoliday int,@leftWorker int
                   ,@OTRateOrg money,@OTAmtOrg money,@ExtraOTRateOrg money,@ExtraOTAmtOrg money,@TotalEarnOrg money,@PresentQty int,@LateQty int,
                   @BasicOrg Money,@HRentOrg Money,@MedicalOrg Money,@salGrp varchar(20),@resignType varchar(20)

             set @fdate= convert(datetime,'01/' +convert(varchar, @FormonthNo) + '/'+ @forYear,103)
            set @ldate= convert(datetime, convert(varchar,@ForMonthsDay) + '/' + convert(varchar,@FormonthNo) + '/'+ @forYear,103)

	Declare curSalary Cursor
	Forward_Only
	Keyset
	Scroll_locks
	For

           Select EMPID ,isnull(sum(PresentQty),0)-isnull(sum(HolidayWork),0),isnull(sum(ot),0),isnull(sum(ot),0),isnull(sum(HolidayWork),0),isnull(sum(holidayQty),0)
           ,isnull(sum(absentqty),0)-isnull(sum(holidayqty),0)+isnull(sum(holidayWork),0)-isnull(sum(leaveqty),0),isnull(sum(GovHoliday),0),isnull(sum(LateQty),0)
,isnull(sum(nwDay),0)
            from dailyattn  where month(attndate)=@forMonthno 
           and year(attndate)=@foryear and comid=@comid  group by empid --and empid in (select empid from temsalprocess)
           Open curSalary
           Fetch Next from curSalary into @EmpID,@AttnDay,@ExtraotHour,@otHour,@holidayWork,@holiday,@absDay,@GovHoliday,@LateQty
,@nwDay
           while @@Fetch_Status=0
	
	Begin



 set @transport=0 set @Alnc=0  set @GrossB =0  set @Basic =0 set @HRent =0 set @Medical =0 set @OTAmt =0  set @AbsDay =0 set @OthersAdd =0 set @AdvDed =0 Set @BasicOrg=0 set @HRentOrg =0
   set @AbsDed =0 set @OthersDed =0  set @totalEarn =0 set @totalDed =0 set @netPay =0 set @OtCheck =0 set @leaveWithPay =0    set @GrossOrg =0  set @AttnBonus=0
   set @Workday =0   set @netPayOrg =0 set  set @AttnBonCheck =0 set @DegId =0 set @AttnBonus =0  set @IncAmt=0 set @NEwEmp=0 set @TotalEarnOrg=0 set @TotalEarn=0
   set @IncAmt=0 set @AbsDedorg =0 set @CL=0 set @SL=0 set @EL=0 set @ML=0  set @advDed=0  set @GradeID =0 set @OTDed=0 set @leftWorker=0
  set @OTRateOrg =0 set @OTAmtOrg =0 set @ExtraOTRateOrg=0 set @ExtraOTAmtOrg=0 set @TotalEarnOrg =0 set @totalDedOrg=0  set @netPay=0 set @netPayOrg= 0
set @MedicalOrg =0  set @prodqty=0  set @prodAmt=0


 select @type=type,@Alnc=allnc,@saltype=saltype,@resignType=resignType,@grossB =isnull(gross,0),@GrossOrg=GrossUsd,@sectionId=sectionCode,@GradeID=LineCode,@GradeID=gradeCode,@desId=designationCode,@AttnBonCheck=attendenceBonus,
@OtCheck=Overtime,@EmpAutoNo=EmpAutoNo,@JDAte=joindate,@resignDate=terminationdate,@Shift=Shift from employee where empid=@empid  and comid=@comid


select @othersAdd=othersAdd,@othersDed=othersDeduct,@transport=transport from monthlyAttn  where empid=@empid and formonth=@forMonth and foryear=@foryear  and comid=@comid

select @advDed=isnull(sum(Paidamount),0) from Advancedetails where AdvanceCode=(select AdvanceCode from advance where 
empid=@empid) and Datename(m,Paydate)=@forMonth and year(Paydate)=@foryear  and comid=@comid


 select @IncAmt =isnull(sum(incamt),0) from increment where empid=@empid and incdate > convert(datetime,@ldate,103)  and comid=@comid

set @TA =200
set @Food =650
set @Stamp=10

if @formonthno=month(@resigndate) and @foryear=year(@resigndate)
begin
set @leftworker=1 
end

if @jdate between convert(datetime,@fdate,103) and convert(datetime,@ldate,103)
begin
set @newEmp=1
end 

/*

set @Medical=1100
set @grossB=isnull(@grossB,0)--isnull(@IncAmt,0)
set @basic=(@grossB-@Medical)  / 1.4
set @hrent=isnull(@basic*0.4,0)
*/



select @cL=isnull(sum(lqty),0) from leave where typeofleave='CL' and empid=@empid and leavedate between convert(datetime,@fdate,103) and convert(datetime,@ldate,103)  and comid=@comid
select @sL=isnull(sum(lqty),0) from leave where typeofleave='sL' and empid=@empid and leavedate between convert(datetime,@fdate,103) and convert(datetime,@ldate,103)   and comid=@comid
select @mL=isnull(sum(lqty),0) from leave where typeofleave='mL' and empid=@empid and leavedate between convert(datetime,@fdate,103) and convert(datetime,@ldate,103)  and comid=@comid
select @eL=isnull(sum(lqty),0) from leave where typeofleave='eL' and empid=@empid and leavedate between convert(datetime,@fdate,103) and convert(datetime,@ldate,103)  and comid=@comid

set @Workday=@forMonthsDay-@holiday--@GovHoliday

set @SalaryDay=@attnDay+@CL+@SL+@EL+@holiday--+@GovHoliday


set @AbsDay=@forMonthsDay-(@attnday+@CL+@SL+@EL+@holiday)

set @AttnBonus=0 set @nwAmt=0

if @AttnBonCheck=1 
Begin
select @AttnBonus=attnbonus  from Designation where DesignationCode=@desId   and comid=@comid
end 

if  @AbsDay<>0 
Begin
set @AttnBonus=0
end 


set @extraOtAmt=0

set @lateDed=0

if @lateqty>=5 and @type='worker'
begin
set @lateDed=round((@grossOrg/@forMOnthsday),0)
end

if @saltype='1'  --piece rated
begin
set @saltype='Piece Rated'
set @basic=@alnc
select @prodqty=isnull(sum(qty),0),@prodAmt=isnull(sum(total),0) from monthlyPcsEntry where empautono=@empautono

set @totalEarnOrg=((@basic/@formonthsDay)*@salaryDay)+@prodAmt+@attnBonus
set @netPayOrg=@totalEarnOrg-@transport-10-@lateDed


set @nwAmt=round((@grossOrg/@formonthsDay)*@nWDay,0)
end







if @saltype='0' --fixed
begin
set @saltype='Fixed'
set @MedicalOrg=1100

set @grossOrg=isnull(@grossOrg,0)--isnull(@IncAmt,0)
set @basicOrg=(@grossOrg-@MedicalOrg)  / 1.4
set @hrentOrg=isnull(@basicOrg*0.4,0)




if @otHour>0 and @OtCheck=1
begin
set @otAmt=isnull(@basic,0)*isnull(@otHour,0)/104
set @otAmtOrg=isnull(@basicOrg,0) * isnull(@otHour,0)/104
set @OTRate=isnull(@basic,0)/104
set @OTRateOrg=isnull(@basicOrg,0)/104

end

set @extraOtAmt=@otAmtOrg


if  @OtCheck=0
begin

set @otAmtOrg=0
set @OTRate=0
set @OTRateOrg=0
set @otAmt=0
set @otHour=0
set @extraOtAmt=0
end


set @totalEarnOrg=((@grossOrg/@formonthsDay)*@salaryDay)+@attnBonus
set @netPayOrg=@totalEarnOrg+@extraOtAmt-@transport-10-@lateded
end


/*

set @AbsDed=@Basic / @Workday*convert(money,@AbsDay)
set @AbsDedOrg=(@GrossOrg) / @forMonthsDay*convert(money,@AbsDay)
set @TotalEarn=isnull(@GrossB,0)+isnull(@AttnBonus,0)+isnull(@OTAmt,0)+isnull(@othersAdd,0)
set @totalDed=isnull(@AbsDed,0)+isnull(@Stamp,0)+isnull(@AdvDed,0)+isnull(@othersDed,0)
set @netPay=isnull(@totalEarn,0)-isnull(@totalDed,0)

*/

if @PresentQty=0 
begin
set @TotalEarn=0
set @netPay=0
end


set @salGrp='Regular'

if @jdate between convert(datetime,@fdate,103) and convert(datetime,@ldate,103)
begin
set @salGrp='New Join'
end


if @resignDate between convert(datetime,@fdate,103) and convert(datetime,@ldate,103)-- and @resigntype like 'Left%'
begin
set @salGrp='Lefty'
end

if @resignDate between convert(datetime,@fdate,103) and convert(datetime,@ldate,103) and @resigntype like 'res%'
begin
set @salGrp='Resign'
end

	Insert into MonSalary(incDed,extraLunchDay,extraLunchAmt,cmoney,prodqty,prodamt,GrossB,saltype,EmpID,EmpAutoNo,ForMonth,Foryear,Gross,Basic,HRent,Medical,OTHour,OTAmt,AttnBonus,AttnDay,Absday,HoliDay,OthersAdd,AdvDed
                                ,AbsDedb,othersDed,TotalEarn,totalDed
                                ,netPayb,extraOtHour,GradeCode,sectionCode,designationCode,MonthDay,cl,sl,el,ml,SalaryDay,Stamp,WorkDay,AbsDed,netPay,OTRate,
                                ExtraOTRate,TA,Food,IncAmt,totalDedB,GovHoliday,TotalEarnb,ExtraOTAmt,Shift,PayGross,PayBasic,PayHRent,OTAmtB,PayMedical,salGrp,comid)

                Values(@lateDed,@nwday,@nwAmt,@transport,@prodQty,@prodAmt,@grossB,@saltype,@EmpID,@EmpAutoNo,@Formonth,@ForYear,isnull(@grossOrg,0),isnull(@Basic,0),isnull(@HRent,0),isnull(@Medical,0)
                             ,isnull(@OTHour,0),isnull(@OTAmt,0),isnull(@AttnBonus,0),isnull(@AttnDay,0),isnull(@AbsDay,0)
                             ,isnull(@HoliDay,0),isnull(@OthersAdd,0),isnull(@AdvDed,0),isnull(@AbsDed,0),isnull(@othersded,0)
                             ,isnull(@TotalEarnOrg,0),isnull(@totalDed,0),isnull(@netPay,0),isnull(@ExtraotHour,0),convert(Varchar,@GradeID)
                             ,@sectionid,@desID,@forMonthsDay,isnull(@CL,0),isnull(@SL,0),isnull(@EL,0),isnull(@ML,0),isnull(@SalaryDay,0),@Stamp,isnull(@Workday,0)
                             ,isnull(@AbsDedOrg,0),isnull(@netPayOrg,0),isnull(@OTRate,0),isnull(@OTRateOrg,0),@TA,@Food,isnull(@IncAmt,0),isnull(@totalDedOrg,0),
                              isnull(@GovHoliday,0),isnull(@TotalEarn,0),isnull(@ExtraOTAmt,0),@Shift,isnull(@GrossOrg,0),isnull(@BasicOrg,0),isnull(@HRentOrg,0)
                              ,isnull(@OTAmtOrg,0), isnull(@MedicalOrg,0) ,@salGrp,@comid)


		Fetch Next from curSalary into @EmpID,@AttnDay,@otHour,@ExtraotHour,@holidayWork,@holiday,@absDay,@GovHoliday,@LateQty,@nwDay

DELETE FROM MONSALARY WHERE FORMONTH=@FORMONTH AND FORYEAR=@FORYEAR AND  empid in (select empid from employee where terminationdate<=convert(datetime,@fdate,103))



exec spLogFile

if @@Error <> 0
		Begin
		Rollback Transaction
		Raiserror('Insertion Failed',16,1)
		Return -1
		End	
	End
Deallocate cursalary







GO
/****** Object:  StoredProcedure [dbo].[SpSalProcessFromM]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO











CREATE PROCEDURE [dbo].[SpSalProcessFromM]
	 @ForMonth varchar(9)
	,@ForYear varchar(9)
	,@FormonthNo int
	,@ForMonthsDay int,@comid varchar(10)

	
As

DELETE FROM MONSALARY WHERE FORMONTH=@FORMONTH AND FORYEAR=@FORYEAR and  empid in 
(select empid from monthlyattn where formonth=@formonth and foryear=@foryear and totattnday>0)
--AND EMPID IN (SELECT EMPID FROM TEMSALPROCESS)
update employee set terminationdate =null where year(terminationdate)=1900
--exec SpAdvProcess @forMonth,@forYear,@forMonthNo,@ForMonthsDay

          declare @EmpId varchar(10),@Gross money ,@Gr money ,@Basic Money,@HRent Money,@Medical money,@OTHour money,@OTRate money,@OTAmt money,@ExtraOTHour money,@ExtraOTRate money,@ExtraOTAmt money,
          @AttnBonus money,@AttnDay int,@AbsDay int,@HoliDay int,@FestivalDay int,@OthersAdd money,@AdvDed money,@AbsDed money,@OthersDed money,@FDAte datetime
	    ,@TotalEarn money,@TotalDed money,@NetPay money,@JDate datetime,@HolidayWork int,@OtCheck int,@leaveWithPay int,@Workday int,@GradeID varchar(50)
                   ,@DegId varchar (10),@AttnBonCheck int,@SalaryDay money,@Stamp  money ,@LineCode varchar(50),@resigndate datetime,@NewEmp int,@Shift varchar(50)
                   ,@IncYear varchar (20),@ldate datetime,@IncAmt money,@sectionid varchar(50),@desId varchar(50),@AbsdedOrg money, @NetPayOrg money,@GrossOrg money
                   ,@CL int,@SL int,@EL int,@ML int ,@OTDed money, @TA money ,@Food money,@TotalDedOrg money,@EmpAutoNo int,@GovHoliday int,@leftWorker int
                   ,@OTRateOrg money,@OTAmtOrg money,@ExtraOTRateOrg money,@ExtraOTAmtOrg money,@TotalEarnOrg money,@PresentQty int,@LateQty int,
                   @BasicOrg Money,@HRentOrg Money,@MedicalOrg Money,@salGrp varchar(20),@resignType varchar(20)

             set @fdate= convert(datetime,'01/' +convert(varchar, @FormonthNo) + '/'+ @forYear,103)
            set @ldate= convert(datetime, convert(varchar,@ForMonthsDay) + '/' + convert(varchar,@FormonthNo) + '/'+ @forYear,103)

	Declare curSalary Cursor
	Forward_Only
	Keyset
	Scroll_locks
	For

           Select EMPID ,attnday,otHr,extraOt from monthatth where formonth=@formonth and foryear=@foryear and totattnday>0
           Open curSalary
           Fetch Next from curSalary into @EmpID,@AttnDay,@otHour,@ExtraotHour
           while @@Fetch_Status=0
	
	Begin



   set @Gross =0  set @Basic =0 set @HRent =0 set @Medical =0 set @OTAmt =0  set @AbsDay =0 set @OthersAdd =0 set @AdvDed =0 Set @BasicOrg=0 set @HRentOrg =0
   set @AbsDed =0 set @OthersDed =0  set @totalEarn =0 set @totalDed =0 set @netPay =0 set @OtCheck =0 set @leaveWithPay =0    set @GrossOrg =0  set @AttnBonus=0
   set @Workday =0   set @netPayOrg =0 set  set @AttnBonCheck =0 set @DegId =0 set @AttnBonus =0  set @IncAmt=0 set @NEwEmp=0 set @TotalEarnOrg=0 set @TotalEarn=0
   set @IncAmt=0 set @AbsDedorg =0 set @CL=0 set @SL=0 set @EL=0 set @ML=0  set @advDed=0  set @GradeID =0 set @OTDed=0 set @leftWorker=0
  set @OTRateOrg =0 set @OTAmtOrg =0 set @ExtraOTRateOrg=0 set @ExtraOTAmtOrg=0 set @TotalEarnOrg =0 set @totalDedOrg=0  set @netPay=0 set @netPayOrg= 0
set @MedicalOrg =0

 select @resignType=resignType,@gross =isnull(gross,0),@GrossOrg=GrossUsd,@sectionId=sectionCode,@GradeID=LineCode,@GradeID=gradeCode,@desId=designationCode,@AttnBonCheck=attendenceBonus,
@OtCheck=Overtime,@EmpAutoNo=EmpAutoNo,@JDAte=joindate,@resignDate=terminationdate,@Shift=Shift from employee where empid=@empid 

 select @IncAmt =isnull(sum(incamt),0) from increment where empid=@empid and incdate > convert(datetime,@ldate,103)

select @othersAdd=othersAdd,@othersDed=othersDeduct from monthlyAttn  where empid=@empid and formonth=@forMonth and foryear=@foryear

select @advDed=isnull(sum(Paidamount),0) from Advancedetails where AdvanceCode=(select AdvanceCode from advance where 
empid=@empid) and Datename(m,Paydate)=@forMonth and year(Paydate)=@foryear

set @TA =200
set @Food =650
set @Stamp=10

if @formonthno=month(@resigndate) and @foryear=year(@resigndate)
begin
set @leftworker=1 
end

if @jdate between convert(datetime,@fdate,103) and convert(datetime,@ldate,103)
begin
set @newEmp=1
end 

set @grossOrg=isnull(@grossOrg,0)-isnull(@IncAmt,0)
set @basicOrg=(@grossOrg-200)  / 1.4
set @hrentOrg=isnull(@basicOrg*0.4,0)
set @MedicalOrg=200

set @gross=isnull(@gross,0)-isnull(@IncAmt,0)
set @basic=(@gross-@TA-@Food-250)  / 1.4
set @hrent=isnull(@basic*0.4,0)
set @Medical=250



if @otHour>0 and @OtCheck=1
begin
set @otAmt=isnull(@basic,0)*isnull(@otHour,0)/104
set @otAmtOrg=isnull(@basicOrg,0) * isnull(@otHour,0)/104
set @OTRate=isnull(@basic,0)/104
set @OTRateOrg=isnull(@basicOrg,0)/104

end


if  @OtCheck=0
begin

set @otAmtOrg=0
set @OTRate=0
set @OTRateOrg=0
set @otAmt=0
set @otHour=0

end

select @cL=isnull(sum(lqty),0) from leave where typeofleave='CL' and empid=@empid and leavedate between convert(datetime,@fdate,103) and convert(datetime,@ldate,103)
select @sL=isnull(sum(lqty),0) from leave where typeofleave='sL' and empid=@empid and leavedate between convert(datetime,@fdate,103) and convert(datetime,@ldate,103)
select @mL=isnull(sum(lqty),0) from leave where typeofleave='mL' and empid=@empid and leavedate between convert(datetime,@fdate,103) and convert(datetime,@ldate,103)
select @eL=isnull(sum(lqty),0) from leave where typeofleave='eL' and empid=@empid and leavedate between convert(datetime,@fdate,103) and convert(datetime,@ldate,103)

set @Workday=@forMonthsDay-@holiday-@GovHoliday

set @SalaryDay=@attnDay--+@CL+@SL+@EL+@holiday+@GovHoliday


set @AbsDay=@forMonthsDay-@attnday

set @AttnBonus=0

if @AttnBonCheck=1 
Begin
select @AttnBonus=attnbonus  from Designation where DesignationCode=@desId 
end 

if  @AbsDay<>0 or @LateQty<>0
Begin
set @AttnBonus=0
end 



set @AbsDed=@Basic / @Workday*convert(money,@AbsDay)

set @AbsDedOrg=(@GrossOrg) / @forMonthsDay*convert(money,@AbsDay)

set @TotalEarn=isnull(@Gross,0)+isnull(@AttnBonus,0)+isnull(@OTAmt,0)+isnull(@othersAdd,0)

set @TotalEarnOrg=isnull(@GrossOrg,0)+isnull(@AttnBonus,0)+isnull(@OTAmtOrg,0)+isnull(@othersAdd,0)

set @totalDed=isnull(@AbsDed,0)+isnull(@Stamp,0)+isnull(@AdvDed,0)+isnull(@othersDed,0)

set @totalDedOrg=isnull(@AbsDedOrg,0)+isnull(@Stamp,0)+isnull(@AdvDed,0)+isnull(@othersDed,0)

set @netPay=isnull(@totalEarn,0)-isnull(@totalDed,0)

set @netPayOrg=isnull(@TotalEarnOrg,0)-isnull(@totalDedOrg,0)

if @PresentQty=0 
begin
set @TotalEarn=0
set @netPay=0
end


set @salGrp='Regular'

if @jdate between convert(datetime,@fdate,103) and convert(datetime,@ldate,103)
begin
set @salGrp='New Join'
end


if @resignDate between convert(datetime,@fdate,103) and convert(datetime,@ldate,103)-- and @resigntype like 'Left%'
begin
set @salGrp='Lefty'
end

if @resignDate between convert(datetime,@fdate,103) and convert(datetime,@ldate,103) and @resigntype like 'res%'
begin
set @salGrp='Resign'
end

	Insert into MonSalary(EmpID,EmpAutoNo,ForMonth,Foryear,Gross,Basic,HRent,Medical,OTHour,OTAmt,AttnBonus,AttnDay,Absday,HoliDay,OthersAdd,AdvDed
                                ,AbsDedb,othersDed,TotalEarn,totalDed
                                ,netPayb,extraOtHour,GradeCode,sectionCode,designationCode,MonthDay,cl,sl,el,ml,SalaryDay,Stamp,WorkDay,AbsDed,netPay,OTRate,
                                ExtraOTRate,TA,Food,IncAmt,totalDedB,GovHoliday,TotalEarnb,ExtraOTAmt,Shift,PayGross,PayBasic,PayHRent,OTAmtB,PayMedical,salGrp)

                Values(@EmpID,@EmpAutoNo,@Formonth,@ForYear,isnull(@Gross,0),isnull(@Basic,0),isnull(@HRent,0),isnull(@Medical,0)
                             ,isnull(@OTHour,0),isnull(@OTAmt,0),isnull(@AttnBonus,0),isnull(@AttnDay,0),isnull(@AbsDay,0)
                             ,isnull(@HoliDay,0),isnull(@OthersAdd,0),isnull(@AdvDed,0),isnull(@AbsDed,0),isnull(@othersded,0)
                             ,isnull(@TotalEarn,0),isnull(@totalDed,0),isnull(@netPay,0),isnull(@ExtraotHour,0),convert(Varchar,@GradeID)
                             ,@sectionid,@desID,@forMonthsDay,isnull(@CL,0),isnull(@SL,0),isnull(@EL,0),isnull(@ML,0),isnull(@SalaryDay,0),@Stamp,isnull(@Workday,0)
                             ,isnull(@AbsDedOrg,0),isnull(@netPayOrg,0),isnull(@OTRate,0),isnull(@OTRateOrg,0),@TA,@Food,isnull(@IncAmt,0),isnull(@totalDedOrg,0),
                              isnull(@GovHoliday,0),isnull(@TotalEarn,0),isnull(@ExtraOTAmt,0),@Shift,isnull(@GrossOrg,0),isnull(@BasicOrg,0),isnull(@HRentOrg,0)
                              ,isnull(@OTAmtOrg,0), isnull(@MedicalOrg,0) ,@salGrp)


           Fetch Next from curSalary into @EmpID,@AttnDay,@otHour,@ExtraotHour

DELETE FROM MONSALARY WHERE FORMONTH=@FORMONTH AND FORYEAR=@FORYEAR AND  empid in (select empid from employee where terminationdate<convert(datetime,@fdate,103))



exec spLogFile

if @@Error <> 0
		Begin
		Rollback Transaction
		Raiserror('Insertion Failed',16,1)
		Return -1
		End	
	End
Deallocate cursalary








GO
/****** Object:  StoredProcedure [dbo].[SpSalProcessFromMonthlyAttn]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO












CREATE PROCEDURE [dbo].[SpSalProcessFromMonthlyAttn]
	 @ForMonth varchar(9)
	,@ForYear int
	,@FormonthNo int
	,@ForMonthsDay int,@comid varchar(10)
As

DELETE FROM MONSALARY WHERE FORMONTH=@FORMONTH AND FORYEAR=@FORYEAR and  comid=@comid and empid in 
(select empid from monthlyattn where formonth=@formonth and foryear=@foryear and totattnday>0 and comid=@comid)
--AND EMPID IN (SELECT EMPID FROM TEMSALPROCESS)
update employee set terminationdate =null where year(terminationdate)=1900
--exec SpAdvProcess @forMonth,@forYear,@forMonthNo,@ForMonthsDay

          declare @EmpId varchar(10),@Gross money ,@Gr money ,@Basic Money,@HRent Money,@Medical money,@OTHour money,@OTRate money,@OTAmt money,@ExtraOTHour money,@ExtraOTRate money,@ExtraOTAmt money,
          @AttnBonus money,@AttnDay int,@AbsDay int,@HoliDay int,@FestivalDay int,@OthersAdd money,@AdvDed money,@AbsDed money,@OthersDed money,@FDAte datetime
	    ,@TotalEarn money,@TotalDed money,@NetPay money,@JDate datetime,@HolidayWork int,@OtCheck int,@leaveWithPay int,@Workday int,@GradeID varchar(50)
                   ,@DegId varchar (10),@AttnBonCheck int,@SalaryDay money,@Stamp  money ,@LineCode varchar(50),@resigndate datetime,@NewEmp int,@Shift varchar(50)
                   ,@IncYear varchar (20),@ldate datetime,@IncAmt money,@sectionid varchar(50),@desId varchar(50),@AbsdedOrg money, @NetPayOrg money,@GrossOrg money
                   ,@CL int,@SL int,@EL int,@ML int ,@OTDed money, @TA money ,@Food money,@TotalDedOrg money,@EmpAutoNo int,@GovHoliday int,@leftWorker int
                   ,@OTRateOrg money,@OTAmtOrg money,@ExtraOTRateOrg money,@ExtraOTAmtOrg money,@TotalEarnOrg money,@PresentQty int,@LateQty int,
                   @BasicOrg Money,@HRentOrg Money,@MedicalOrg Money,@salGrp varchar(20),@resignType varchar(20)

---             set @fdate= convert(datetime,'01/' +convert(varchar, @FormonthNo) + '/'+ @forYear,103)
----            set @ldate= convert(datetime, convert(varchar,@ForMonthsDay) + '/' + convert(varchar,@FormonthNo) + '/'+ @forYear,103)


	Declare curSalary Cursor
	Forward_Only
	Keyset
	Scroll_locks
	For

           Select EMPID ,totattnday,otHr,extraOt from monthlyAttn where formonth=@formonth and foryear=@foryear and totattnday>0 and comid=@comid
           Open curSalary
           Fetch Next from curSalary into @EmpID,@AttnDay,@otHour,@ExtraotHour
           while @@Fetch_Status=0
	
	Begin



   set @Gross =0  set @Basic =0 set @HRent =0 set @Medical =0 set @OTAmt =0  set @AbsDay =0 set @OthersAdd =0 set @AdvDed =0 Set @BasicOrg=0 set @HRentOrg =0
   set @AbsDed =0 set @OthersDed =0  set @totalEarn =0 set @totalDed =0 set @netPay =0 set @OtCheck =0 set @leaveWithPay =0    set @GrossOrg =0  set @AttnBonus=0
   set @Workday =0   set @netPayOrg =0 set  set @AttnBonCheck =0 set @DegId =0 set @AttnBonus =0  set @IncAmt=0 set @NEwEmp=0 set @TotalEarnOrg=0 set @TotalEarn=0
   set @IncAmt=0 set @AbsDedorg =0 set @CL=0 set @SL=0 set @EL=0 set @ML=0  set @advDed=0  set @GradeID =0 set @OTDed=0 set @leftWorker=0
  set @OTRateOrg =0 set @OTAmtOrg =0 set @ExtraOTRateOrg=0 set @ExtraOTAmtOrg=0 set @TotalEarnOrg =0 set @totalDedOrg=0  set @netPay=0 set @netPayOrg= 0
set @MedicalOrg =0

 select @resignType=resignType,@gross =isnull(gross,0),@GrossOrg=GrossUsd,@sectionId=sectionCode,@GradeID=LineCode,@GradeID=gradeCode,@desId=designationCode,@AttnBonCheck=attendenceBonus,
@OtCheck=Overtime,@EmpAutoNo=EmpAutoNo,@JDAte=joindate,@resignDate=terminationdate,@Shift=Shift from employee where empid=@empid and comid=@comid

 select @IncAmt =isnull(sum(incamt),0) from increment where empid=@empid and incdate > convert(datetime,@ldate,103) and comid=@comid

select @othersAdd=othersAdd,@othersDed=othersDeduct from monthlyAttn  where empid=@empid and formonth=@forMonth and foryear=@foryear and comid=@comid

select @advDed=isnull(sum(Paidamount),0) from Advancedetails where AdvanceCode=(select AdvanceCode from advance where 
empid=@empid) and Datename(m,Paydate)=@forMonth and year(Paydate)=@foryear and comid=@comid

set @TA =200
set @Food =650
set @Stamp=10

if @formonthno=month(@resigndate) and @foryear=year(@resigndate)
begin
set @leftworker=1 
end

if @jdate between convert(datetime,@fdate,103) and convert(datetime,@ldate,103)
begin
set @newEmp=1
end 

set @grossOrg=isnull(@grossOrg,0)-isnull(@IncAmt,0)
set @basicOrg=(@grossOrg-200)  / 1.4
set @hrentOrg=isnull(@basicOrg*0.4,0)
set @MedicalOrg=200

set @gross=isnull(@gross,0)-isnull(@IncAmt,0)
set @basic=(@gross-@TA-@Food-250)  / 1.4
set @hrent=isnull(@basic*0.4,0)
set @Medical=250



if @otHour>0 and @OtCheck=1
begin
set @otAmt=isnull(@basic,0)*isnull(@otHour,0)/104
set @otAmtOrg=isnull(@basicOrg,0) * isnull(@otHour,0)/104
set @OTRate=isnull(@basic,0)/104
set @OTRateOrg=isnull(@basicOrg,0)/104

end


if  @OtCheck=0
begin

set @otAmtOrg=0
set @OTRate=0
set @OTRateOrg=0
set @otAmt=0
set @otHour=0

end

select @cL=isnull(sum(lqty),0) from leave where typeofleave='CL' and empid=@empid and leavedate between convert(datetime,@fdate,103) and convert(datetime,@ldate,103)  and comid=@comid
select @sL=isnull(sum(lqty),0) from leave where typeofleave='sL' and empid=@empid and leavedate between convert(datetime,@fdate,103) and convert(datetime,@ldate,103) and comid=@comid
select @mL=isnull(sum(lqty),0) from leave where typeofleave='mL' and empid=@empid and leavedate between convert(datetime,@fdate,103) and convert(datetime,@ldate,103) and comid=@comid
select @eL=isnull(sum(lqty),0) from leave where typeofleave='eL' and empid=@empid and leavedate between convert(datetime,@fdate,103) and convert(datetime,@ldate,103) and comid=@comid

set @Workday=@forMonthsDay-@holiday-@GovHoliday

set @SalaryDay=@attnDay--+@CL+@SL+@EL+@holiday+@GovHoliday


set @AbsDay=@forMonthsDay-@attnday

set @AttnBonus=0

if @AttnBonCheck=1 
Begin
select @AttnBonus=attnbonus  from Designation where DesignationCode=@desId  and comid=@comid
end 

if  @AbsDay<>0 or @LateQty<>0
Begin
set @AttnBonus=0
end 



set @AbsDed=@Basic / @Workday*convert(money,@AbsDay)

set @AbsDedOrg=(@GrossOrg) / @forMonthsDay*convert(money,@AbsDay)

set @TotalEarn=isnull(@Gross,0)+isnull(@AttnBonus,0)+isnull(@OTAmt,0)+isnull(@othersAdd,0)

set @TotalEarnOrg=isnull(@GrossOrg,0)+isnull(@AttnBonus,0)+isnull(@OTAmtOrg,0)+isnull(@othersAdd,0)

set @totalDed=isnull(@AbsDed,0)+isnull(@Stamp,0)+isnull(@AdvDed,0)+isnull(@othersDed,0)

set @totalDedOrg=isnull(@AbsDedOrg,0)+isnull(@Stamp,0)+isnull(@AdvDed,0)+isnull(@othersDed,0)

set @netPay=isnull(@totalEarn,0)-isnull(@totalDed,0)

set @netPayOrg=isnull(@TotalEarnOrg,0)-isnull(@totalDedOrg,0)

if @PresentQty=0 
begin
set @TotalEarn=0
set @netPay=0
end


set @salGrp='Regular'

if @jdate between convert(datetime,@fdate,103) and convert(datetime,@ldate,103)
begin
set @salGrp='New Join'
end


if @resignDate between convert(datetime,@fdate,103) and convert(datetime,@ldate,103)-- and @resigntype like 'Left%'
begin
set @salGrp='Lefty'
end

if @resignDate between convert(datetime,@fdate,103) and convert(datetime,@ldate,103) and @resigntype like 'res%'
begin
set @salGrp='Resign'
end

	Insert into MonSalary(EmpID,EmpAutoNo,ForMonth,Foryear,Gross,Basic,HRent,Medical,OTHour,OTAmt,AttnBonus,AttnDay,Absday,HoliDay,OthersAdd,AdvDed
                                ,AbsDedb,othersDed,TotalEarn,totalDed
                                ,netPayb,extraOtHour,GradeCode,sectionCode,designationCode,MonthDay,cl,sl,el,ml,SalaryDay,Stamp,WorkDay,AbsDed,netPay,OTRate,
                                ExtraOTRate,TA,Food,IncAmt,totalDedB,GovHoliday,TotalEarnb,ExtraOTAmt,Shift,PayGross,PayBasic,PayHRent,OTAmtB,PayMedical,salGrp,comid)

                Values(@EmpID,@EmpAutoNo,@Formonth,@ForYear,isnull(@Gross,0),isnull(@Basic,0),isnull(@HRent,0),isnull(@Medical,0)
                             ,isnull(@OTHour,0),isnull(@OTAmt,0),isnull(@AttnBonus,0),isnull(@AttnDay,0),isnull(@AbsDay,0)
                             ,isnull(@HoliDay,0),isnull(@OthersAdd,0),isnull(@AdvDed,0),isnull(@AbsDed,0),isnull(@othersded,0)
                             ,isnull(@TotalEarn,0),isnull(@totalDed,0),isnull(@netPay,0),isnull(@ExtraotHour,0),convert(Varchar,@GradeID)
                             ,@sectionid,@desID,@forMonthsDay,isnull(@CL,0),isnull(@SL,0),isnull(@EL,0),isnull(@ML,0),isnull(@SalaryDay,0),@Stamp,isnull(@Workday,0)
                             ,isnull(@AbsDedOrg,0),isnull(@netPayOrg,0),isnull(@OTRate,0),isnull(@OTRateOrg,0),@TA,@Food,isnull(@IncAmt,0),isnull(@totalDedOrg,0),
                              isnull(@GovHoliday,0),isnull(@TotalEarn,0),isnull(@ExtraOTAmt,0),@Shift,isnull(@GrossOrg,0),isnull(@BasicOrg,0),isnull(@HRentOrg,0)
                              ,isnull(@OTAmtOrg,0), isnull(@MedicalOrg,0) ,@salGrp,@comid)


           Fetch Next from curSalary into @EmpID,@AttnDay,@otHour,@ExtraotHour

DELETE FROM MONSALARY WHERE FORMONTH=@FORMONTH AND FORYEAR=@FORYEAR AND  empid in (select empid from employee where terminationdate<convert(datetime,@fdate,103))



exec spLogFile

if @@Error <> 0
		Begin
		Rollback Transaction
		Raiserror('Insertion Failed',16,1)
		Return -1
		End	
	End
Deallocate cursalary








GO
/****** Object:  StoredProcedure [dbo].[SpShiftTimeUpdate]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO













CREATE PROCEDURE [dbo].[SpShiftTimeUpdate]
@forMonthNo int,
@forYear int,
@comid varchar(10)
As
	Declare  @Empid varchar(10),@providentfundid varchar(10),@sectionid varchar(10),@blockID varchar(10),@HDate datetime,@HReason varchar(30),@grpId varchar(10),@otstart datetime
,@gd int,@AttnDate datetime,@maxin datetime,@intime datetime,@maxot money,@OUTTIME DATETIME,@maxDate datetime,@fdate datetime,@cnt int


select @maxDate=max(setupdate) from timegroup where comid=@comid
set @fdate=convert(datetime,'01/'+convert(varchar,@forMonthNo)+'/'+ convert(varchar,@forYear),103)

select @cnt=count(setupdate) from timeGroup where comid=@comid and setupdate=convert(datetime,@fdate,103)

if @cnt=0
begin

insert timegroup (setupdate,groupid,intime,outtime,maxintime,intimestartfrom,maxot,otstart,comid,lunchMnt)
select convert(datetime,@fdate,103),groupid,intime,outtime,maxintime,intimestartfrom,maxot,otstart,comid,lunchMnt from timegroup 
where setupdate=convert(datetime,@maxDate,103) and comid=@comid

end


update dailyattn set groupid='GENERAL'  where month(attndate)=@forMonthNo and yeAR(ATTNDATE)=@FORYEAR
update dailyattn set groupid='A'  where month(attndate)=@forMonthNo and yeAR(ATTNDATE)=@FORYEAR AND  empid in (select empid from employee where shift='a')
update dailyattn set groupid='B'  where month(attndate)=@forMonthNo and yeAR(ATTNDATE)=@FORYEAR AND  empid in (select empid from employee where shift='b')


--update dailyattn set groupid='GENERAL'  where month(attndate)=@forMonthNo and yeAR(ATTNDATE)=@FORYEAR and comid=@comid --AND isnull(groupid,'')=''

	Declare curSAL Cursor
	Forward_Only
	Keyset
	Scroll_locks
For
select groupid,outtime,OTSTART,setupdate,maxintime,intime,maxot from timegroup  where  month(setupdate)=@forMonthNo and year(setupdate)=@forYear and comid=@comid order by setupdate
	
	Open curSAL
	Fetch  from curSAL into @grpid,@OUTTIME,@otstart,@attndate,@maxin,@intime,@maxot
	while @@Fetch_Status=0
	
	BEGIN
	
--update dailyattn set holidayqty=1,holiay=@hreason,i=null,ib=null,o=null,ob=null,presentqty=0,absentqty=1,status='A',ot=0,otb=0,othr=0,othrb=0,otmnt=0,otmntb=0 where attndate = convert(datetime,@hdate,103)
--update dailyattn set holidayqty=1,holiay=@hreason,GD=@gd where attndate = convert(datetime,@hdate,103)
--update dailyattn set otstart=convert(datetime,@otstart,108) where attndate>=convert(datetime,@attndate,103) and groupid=@grpid


--update dailyattn set  gblInTime=convert(datetime,@intime,108), gbloutTime=convert(datetime,@otstart,108),gblmaxInTime=convert(datetime,@maxIn,108) ,otstartb=convert(datetime,@otstart,108),otstart=convert(datetime,@otstart,108) where attndate>=convert(datetime,@attndate,103) and groupid=@grpid and holidayqty=0
--update dailyattn set  gblInTime=convert(datetime,@intime,108), gbloutTime=convert(datetime,@otstart,108),gblmaxInTime=convert(datetime,@maxIn,108),otstart=dateadd(hh,-8,convert(datetime,@otstart,108)),otstartb=dateadd(hh,-8,convert(datetime,@otstart,108)) where attndate>=convert(datetime,@attndate,103) and holidayqty=1 and groupid=@grpid
update dailyattn set maxot=@maxot,  otstart=convert(datetime,@otstart,108),otstartb=convert(datetime,@otstart,108),GBLmaxintime=convert(datetime,@maxin,108),maxintime=convert(datetime,@maxin,108),
gblInTime=convert(datetime,@inTime,108),gblOutTime=convert(datetime,@outTime,108) where attndate>=convert(datetime,@attndate,103) and groupid=@grpid and comid=@comid
--update dailyattn set  otstart=dateadd(n,30,convert(datetime,@intime,108)),otstartb=dateadd(n,30,convert(datetime,@intime,108)),GBLmaxintime=convert(datetime,@maxin,108) where attndate>=convert(datetime,@attndate,103) and groupid=@grpid and holidayqty=1

Fetch  from curSAL into @grpid,@OUTTIME,@otstart,@attndate,@maxin,@intime,@maxot

if @@Error <> 0
		Begin
		Rollback Transaction
		Raiserror('Insertion Failed',16,1)
		Return -1
		End	
	End
Deallocate curSAL








GO
/****** Object:  StoredProcedure [dbo].[SpShiftUpdate]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO


























CREATE PROCEDURE [dbo].[SpShiftUpdate]
@forMonthNo int,
@forYear int
As
	Declare  @Empid varchar(10),@providentfundid varchar(10),@sectionid varchar(10),@blockID varchar(10),@HDate datetime,@HReason varchar(30),@grpId varchar(10),@otstart datetime
,@gd int,@AttnDate datetime,@maxin datetime,@intime datetime,@maxot money


update dailyattn set groupid='1'  where month(attndate)=@forMonthNo and yeAR(ATTNDATE)=@FORYEAR AND isnull(groupid,'')=''


	Declare curSAL Cursor
	Forward_Only
	Keyset
	Scroll_locks
For
select groupid,outtime,setupdate,maxintime,intime,maxot from timegroup  where  month(setupdate)=@forMonthNo and year(setupdate)=@forYear order by setupdate
	
	Open curSAL
	Fetch  from curSAL into @grpid,@otstart,@attndate,@maxin,@intime,@maxot
	while @@Fetch_Status=0
	
	BEGIN
	

update dailyattn set maxot=@maxot,  otstart=convert(datetime,@otstart,108),maxintime=convert(datetime,@maxin,108) 
where attndate>=convert(datetime,@attndate,103) and groupid=@grpid


	Fetch  from curSAL into @grpid,@otstart,@attndate,@maxin,@intime,@maxot

if @@Error <> 0
		Begin
		Rollback Transaction
		Raiserror('Insertion Failed',16,1)
		Return -1
		End	
	End
Deallocate curSAL
























GO
/****** Object:  StoredProcedure [dbo].[SpShiftUpdateProcess]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
















CREATE PROCEDURE [dbo].[SpShiftUpdateProcess]
@AttnDate varchar(10)

As
	Declare  @Empid varchar(10),@DeviceNo varchar(10),@sectionid varchar(10),@blockID varchar(10),@HDate datetime
,@HReason varchar(30),@grpId varchar(10),@otstart datetime,@prevDate datetime ,@STS VARCHAR(10)
,@gd int,@maxin datetime,@intime datetime,@maxot money,@outtime datetime,@swipedate datetime,@inTimeTem datetime


--update dailyattn set groupid='General'
--'  where month(attndate)=@forMonthNo and yeAR(ATTNDATE)=@FORYEAR --AND isnull(groupid,'')=''

set @prevDate=dateadd(dd,-1,convert(datetime,@attnDate,103))

delete from tm


	Declare curSAL Cursor
	Forward_Only
	Keyset
	Scroll_locks
For
--select empid,swipedate,intime,outtime,deviceNo from vwShiftProcess where swipedate=convert(datetime,@attndate,103)  order by deviceNo
SELECT EMPID,SWIPEDATE,INTIME,OUTTIME,sts FROM vwINOOutAll  where swipedate=convert(datetime,@attndate,103)  ORDER BY
 empid,STS,INTIME DESC,OUTTIME desc
	
	Open curSAL
	Fetch  from curSAL into @empid,@swipedate,@intime,@outtime,@deviceNO
	while @@Fetch_Status=0
	
	BEGIN
	
if @deviceNO='IN'
begin
update dailyattn set i=NULL,o=null where attndate=convert(datetime,@attndate,103) and empid=@empid and ismanualtype=''

update dailyattn set i=convert(datetime,@intime,108),o=null 
where attndate=convert(datetime,@attndate,103) and empid=@empid and ismanualtype=''
end


set @inTimeTem=convert(datetime,'00:00:00',108)


if @deviceNO<>'IN'
begin

select  @inTimeTem=o from dailyattn where attndate=convert(datetime,@attndate,103) and empid=@empid

		if convert(datetime,@OutTime,108) <convert(datetime,'08:00:00',108) 
		begin
		update dailyattn set o=convert(datetime,@OutTime,108) where attndate=convert(datetime,@PrevDate,103) and empid=@empid and ismanualtype=''
		end

-- @inTimeTem<convert(datetime,'13:00:00',108) and
		if convert(datetime,@OutTime,108) >=convert(datetime,'08:00:00',108) 
		begin

if @empid='00821'
begin
insert tm(tm,tmp) values ( convert(datetime,@outtime,108), convert(datetime,@InTimeTem,108))
end
--				if @outTime between convert(datetime,'13:30:00',108) and convert(datetime,'23:59:00',108)
				if isnull(@intimeTem,convert(datetime,'00:00:00',108))< convert(datetime,@outtime,108)
				begin
				update dailyattn set o=convert(datetime,@OutTime,108) where attndate=convert(datetime,@attndate,103) and empid=@empid and ismanualtype=''		update dailyattn set o=convert(datetime,@OutTime,108) where attndate=convert(datetime,@attndate,103) and empid=@empid and ismanualtype=''
				and convert(datetime,@OutTime,108)>=  isnull(o,convert(datetime,'00:00:00',108))
				end
		end

				
end

	Fetch  from curSAL into @empid,@swipedate,@intime,@outtime,@deviceNO
if @@Error <> 0
		Begin
		Rollback Transaction
		Raiserror('Insertion Failed',16,1)
		Return -1
		End	
	End
Deallocate curSAL















GO
/****** Object:  StoredProcedure [dbo].[SPStart]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO

















CREATE PROCEDURE [dbo].[SPStart]
@ComId varchar(10)
As
Declare @SalaryStyle varchar (20)
select @SalaryStyle = SalaryStyle from setting where comid =@ComId
if @SalaryStyle ='BGMEA'
Begin
update employee set basic=Gross-200/1.4
update employee set Medical=300, Hrent=(basic*40)/100
end











GO
/****** Object:  StoredProcedure [dbo].[SpStockRpt]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



--select * from stockrpt

CREATE  PROCEDURE [dbo].[SpStockRpt] @FromDate varchar(10),@ToDate varchar(10),@comID varchar(10),@pcName varchar(50)
AS


exec SPUnitPriceNew @PCName,@comID,@fromDate,@ToDate

--delete from stockrpt where pcname=@pcname

--insert stockrpt (itemautono,itemcode,comid,pcname) select autono,itemcode,@comid,@pcname from item where itemname<>''
--select * from temrpt
delete from temrpt where pcname=@pcname

insert temrpt(itemAutoNo,saleqty,pcname,comid)
select itemAutoNo,isnull(sum(qtyin),0)-isnull(sum(qtyOut),0)-isnull(sum(DamQty),0)+isnull(sum(RetQty),0),@pcname,@comid
from vwStock where thedate<convert(datetime,@FromDate,103) group by itemAutoNo

update stockrpt set opbal=t.saleQty from temRpt t where stockRpt.itemAutoNo=t.ItemAutoNo and  stockRpt.pcname=t.pcname and stockrpt.pcname=@pcname


delete from temrpt where  pcname=@pcname

insert temrpt(itemAutoNo,purchaseqty,saleqty,purchasePrice,salePrice,pcname,comid)
select itemAutoNo,isnull(sum(qtyin),0),isnull(sum(qtyOut),0),isnull(sum(DamQty),0),isnull(sum(RetQty),0),@pcname,@comid
from vwStock where thedate between convert(datetime,@FromDate,103) and convert(datetime,@ToDate,103) group by itemAutoNo

update stockrpt set inQty=t.purchaseqty,OutQty=t.saleQty,DamQty=t.purchasePrice,retQty=t.salePrice
 from temRpt t where stockRpt.itemAutoNo=t.ItemAutoNo and  stockRpt.pcname=t.pcname and stockrpt.pcname=@pcname


update stockrpt set inhandqty=opbal+inQty-OutQty-DamQty+retQty where  pcname=@pcname


--delete from stockrpt where itemautono in (select autono from item where stockMaintain=1)




GO
/****** Object:  StoredProcedure [dbo].[SpTBProcess]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO





















CREATE PROCEDURE
[dbo].[SpTBProcess]
@ComID varchar(10)
,@tillDAte varchar(10)
,@PCNAME VARCHAR(30)
 AS

delete from tb WHERE PCNAME=@PCNAME AND COMID=@ComId

insert tb select h.headname,sum(v.dr)-sum(v.cr),0,@ComID,@PCNAME from head h,vwvoucher v where v.comid=h.comid and v.headid=h.headid and v.Comid=@ComId  and v.vdate<=convert(datetime,@tilldate,103) group by h.headname having sum(v.dr)-sum(v.cr)>0
insert tb select h.headname,0, abs( sum(v.dr)-sum(v.cr)),@ComID,@PCNAME from head h,vwvoucher v where v.comid=h.comid and v.headid=h.headid and v.Comid=@ComID  and  v.vdate<=convert(datetime,@tilldate,103) group by h.headname having sum(v.dr)-sum(v.cr)<0













GO
/****** Object:  StoredProcedure [dbo].[SPTem1]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO


























CREATE Procedure [dbo].[SPTem1]
	
As

Declare @EmpID int,  @PaidAmt money,@intime datetime,@outtime datetime,@ismantype varchar(50),@attndate datetime
,@cardNo varchar(10)

set @empid=10001

Declare curAdv Cursor
	Forward_only
	Keyset
	Scroll_locks
For
select top 200 card_no from data_card where d_card='20111112' and convert(money,t_card)<80000
Open curAdv 
Fetch from curAdv into @cardno
while @@Fetch_Status=0
Begin


update employee set cardno=@cardno where empid=@empid

set @empid=@empid+1

Fetch from curAdv into @cardno
	
	/*if @@Error<>0
	Begin
	Raiserror('Data not input properly',1,1)
	Rollback Tran
	Return -1
	End
*/
End
--commit tran
Deallocate curAdv





















GO
/****** Object:  StoredProcedure [dbo].[SpTemKnitStockRpt]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO








CREATE PROCEDURE [dbo].[SpTemKnitStockRpt] @FROMDATE VARCHAR(10),@TODATE VARCHAR(10)
AS

DELETE FROM TEMKNIT




--start input
INSERT TEMKNIT (BRNAME,lotNo,inputPrev)

SELECT P.PARTYNAME,'' as MEMONO,ISNULL(SUM(D.QTY),0) FROM PURCHASEMSTR M,PURCHASE D ,PARTYINFO p
 where m.partyautoNo=p.autono and m.autono=d.autonofromMstrTbl and m.purchaseDate<convert(datetime,@fromDate,103)
and m.type in ('in' ,'purchase')
group by p.PartyName--,m.MemoNo


delete from temKnit2

INSERT TEMKNIT2 (BRNAME,lotNo,qty)
SELECT P.PARTYNAME,'' as MEMONO,ISNULL(SUM(D.QTY),0) FROM PURCHASEMSTR M,PURCHASE D ,PARTYINFO p
 where m.partyautoNo=p.autono and m.autono=d.autonofromMstrTbl and m.purchaseDate between  convert(datetime,@fromDate,103) and convert(datetime,@toDate,103)
and m.type in ('in' ,'purchase')
group by p.PartyName--,m.MemoNo

update temKnit set temknit.inputToday=t.qty from temKnit2 t where temknit.brname=t.brname and temknit.lotno=t.lotNo
update temKnit set inputTotal=inputprev+inputtoday



--start output
delete from temKnit2
INSERT TEMKNIT2 (BRNAME,lotNo,qty)

SELECT P.PARTYNAME, '' as MEnONO,ISNULL(SUM(D.QTY),0) FROM saleMstr M,sale D ,PARTYINFO p
 where m.partyauto=p.autono and m.autono=d.autonofromSaleMstr and m.saleDate<convert(datetime,@fromDate,103)
and m.type like 'delivery for%'
group by p.PartyName--,m.MenoNo


update temKnit set temknit.outputPrev=t.qty from temKnit2 t where temknit.brname=t.brname and temknit.lotno=t.lotNo


delete from temKnit2
INSERT TEMKNIT2 (BRNAME,lotNo,qty)

SELECT P.PARTYNAME,'' as MEnONO,ISNULL(SUM(D.QTY),0) FROM saleMstr M,sale D ,PARTYINFO p
 where m.partyauto=p.autono and m.autono=d.autonofromSaleMstr and m.saleDate between convert(datetime,@fromDate,103) and convert(datetime,@toDate,103)
and m.type like 'delivery for%'
group by p.PartyName--,m.MenoNo


update temKnit set temknit.outputToday=t.qty from temKnit2 t where temknit.brname=t.brname and temknit.lotno=t.lotNo

update temKnit set outputTotal=outputprev+outputtoday





--start shipment
delete from temKnit2
INSERT TEMKNIT2 (BRNAME,lotNo,qty)

SELECT P.PARTYNAME,'' as MEnONO,ISNULL(SUM(D.QTY),0) FROM saleMstr M,sale D ,PARTYINFO p
 where m.partyauto=p.autono and m.autono=d.autonofromSaleMstr and m.saleDate<convert(datetime,@fromDate,103)
and m.type = 'delivery'
group by p.PartyName--,m.MenoNo


update temKnit set temknit.ShipmentPrev=t.qty from temKnit2 t where temknit.brname=t.brname and temknit.lotno=t.lotNo



delete from temKnit2
INSERT TEMKNIT2 (BRNAME,lotNo,qty)

SELECT P.PARTYNAME,'' as MEnONO,ISNULL(SUM(D.QTY),0) FROM saleMstr M,sale D ,PARTYINFO p
 where m.partyauto=p.autono and m.autono=d.autonofromSaleMstr and m.saleDate between convert(datetime,@fromDate,103) and convert(datetime,@toDate,103)
and m.type = 'delivery'
group by p.PartyName--,m.MenoNo


update temKnit set temknit.ShipmentToday=t.qty from temKnit2 t where temknit.brname=t.brname and temknit.lotno=t.lotNo


update temKnit set shipmentTotal=shipmentprev+shipmenttoday

update temKnit set shipmentBalance=inputTotal-shipmentTotal
update temKnit set fBalance=outputTotal-shipmentTotal
update temKnit set yBalance=inputTotal-outputTotal








GO
/****** Object:  StoredProcedure [dbo].[SpTradeAc]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO








CREATE PROCEDURE [dbo].[SpTradeAc] @comid varchar(10),@pcName varchar(50),@FromDate varchar(10),@ToDate varchar(10),@userId varchar(50)
AS

declare @openingStock money,@closingStock money,@totExp money, @totIncome money,@openingValue money

exec SpStockRpt @FromDate ,@ToDate ,@comID ,@pcName 

set @openingStock=0
set @closingStock=0

update item set opvalue =opbalqty * latestPurchasePrice --where opbalqty>0

delete from temTradAc-- where comid=@comid and pcname=@pcName

--select @openingValue=isnull(sum(opValue),0) from item where OPBALQTY>0 AND opbaldate between convert(datetime,@FromDate,103) and convert(datetime,@ToDate,103) and comid=@comid
select @openingValue=isnull(sum(openingTotalPrice),0) from stockRpt where pcname=@pcname and comid=@comid

insert into temtradac (head,headamtDr,pcname,comid) values ('Opening Stock',@openingValue,@pcName,@comid)

insert temtradac (head,headamtDr,pcname,comid) select h.HeadName,sum(v.Dr) as DrAmt,@PCName,@Comid from 
voucherMstr m,voucher  v,head h where m.autoNo=v.autoNoFromMstrTbl and m.comid=v.comid and h.headid=v.headid and h.comid=v.Comid and h.comid=@comid and h.type in (select type from accttype where destination='trading a/c expense' and comid=@comid) 
and m.vdate between convert(datetime,@FromDate,103) and  convert(datetime,@ToDate,103) group by h.HeadName order by h.headname

insert temtradac (head,headamtCr,pcname,comid) select h.HeadName,sum(v.cr) as crAmt,@PCName,@comid from 
voucherMstr m,voucher  v,head h where m.autoNo=v.autoNoFromMstrTbl and m.comid=v.comid and h.headid=v.headid and h.comid=@comid 
and h.type in (select type from accttype where destination='trading a/c income' and comid=@comid) 
and m.vdate between convert(datetime,@FromDate,103) and  convert(datetime,@ToDate,103) 
group by h.HeadName order by h.headname



--select @openingStock=isnull(sum(openingTotalPrice),0) from stockRpt where pcname=@pcname and comid=@comid
select @closingStock=isnull(sum(closingTotalPrice),0) from stockRpt where pcname=@pcname and comid=@comid

/*
if @OpeningStock<>0
begin
insert into temtradac (head,headamtDr,pcname,comid) values ('Opening Stock',@OpeningStock,@pcName,@comid)
end

*/

if @closingStock<>0 
begin
insert into temtradac (head,headamtCr,pcname,comid) values ('Closing Stock',@closingStock,@pcName,@comid)
end


select @totExp=isnull(sum(headamtdr),0),@totIncome=isnull(sum(headamtcr),0) from temtradAc where comid=@comid and pcname=@pcname


If @totExp > @totIncome
begin
insert into temtradac (head,headamtCr,pcname,comid) values ('Gross Loss  Transfered to PL A/C',@totExp - @totIncome ,@pcname,@comid)
end

If @totExp <= @totIncome
begin
insert into temtradac (head,headamtDr,pcname,comid) values ('Gross Profit Transfered to PL A/C',@totIncome - @totExp,@pcname,@comid)
end

update temTradAc set slno=0 where head like 'opening%'  and comid=@comid and pcname=@pcname
update temTradAc set slno=1 where head like 'Purcha%' and comid=@comid and pcname=@pcname
update temTradAc set slno=AutoNo+100 where head like 'gross %' and comid=@comid and pcname=@pcname
update temTradAc set type='Trade' where comid=@comid and pcname=@pcname
delete from temTradAc  where round(headAmtDr+headAmtCr,0)=0 and comid=@comid and pcname=@pcname




GO
/****** Object:  StoredProcedure [dbo].[SPUnitPrice]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO





CREATE PROCEDURE [dbo].[SPUnitPrice]

	 @PCName varchar(100)
	,@comID varchar(50)
,@fromDate varchar(10)
,@ToDate VarChar(10)
,@UserID varchar(50)
	
As

declare @ItemAutoNo int,@inqty money,@outqty money,@retqty money,@damqty money,@ClosingUnitPrice money
,@openingUnitPrice money,@unitPrice money,@totalPrice money,@totalQty money


DELETE FROM temUnitPrice --WHERE pcName=@pcname AND comid=@comid
delete from stockrpt --where comid=@comid and pcname=@pcname


insert stockrpt (ItemAutoNo,opbal,comid,usercode,pcname)
select itemautono,isnull(sum(qtyin),0)-isnull(sum(qtyout),0)-isnull(sum(damqty),0)+isnull(sum(retqty),0),comid,@userID,@pcName
from vwstock where thedate <convert(datetime,@fromDate,103) and comid=@comid group by itemAutoNo,comid


insert stockrpt (ItemAutoNo,opbal,comid,usercode,pcname)
select autono,0,comid,@UserID,@PCName from item where comid=@comid and convert(varchar,autono) + @UserID
not in (select convert(varchar,itemautono) + @UserID from stockrpt where comid=@comId 
and usercode=@UserID and pcname=@PCName)


	Declare curSalary Cursor
	Forward_Only
	Keyset
	Scroll_locks
	For
   	Select autoNo from item where comid=@comid

	Open curSalary
	Fetch Next from curSalary into @itemAutoNo
	while @@Fetch_Status=0
	
	Begin

                                            
    
set @inqty = 0
set @outqty = 0
set @damqty = 0
set @retqty = 0
set @openingUnitPrice=0
set @closingUnitPrice=0

          
select @inQty=isnull(sum(qtyin),0),@outQty=isnull(sum(qtyout),0),@DamQty=isnull(sum(damqty),0)
,@RetQty=isnull(sum(retqty),0) from vwstock where thedate between convert(datetime,@FromDAte,103)
 and  convert(datetime,@ToDate,103) and itemautono=@ItemAutoNo and comid=@ComID

--select @opUnitPrice=isnull(avg(UnitPrice),0) from purchase where itemautono=@ItemAutoNo  and purchasedate<=convert(datetime,@todate,103)

    
--select @UnitPrice=isnull(avg(UnitPrice),0) from purchase where itemautono=@ItemAutoNo and purchasedate <=convert(datetime,@toDate,103)
set @totalPrice=0
set @totalQty=0

select @totalPrice=isnull(sum(opValue),0) , @totalQty=isnull(sum(opbalqty),0) from item where autono=@ItemAutoNo  and opValue>0 and opbalqty>0 and comid=@comid
and opbaldate <convert(datetime,@toDate,103)

select @totalPrice=@totalPrice+isnull(sum(totalPrice),0),@totalQty=@totalQty+ isnull(sum(qty),0) from purchase where itemautono=@ItemAutoNo and
 purchasedate <convert(datetime,@FromDate,103) and unitprice>0 and qty>0 and comid=@comid

if @totalQty<>0
begin
set @OpeningUnitPrice=@totalPrice/@totalQty
end

--select @OpeningUnitPrice=isnull(sum(totalPrice),0)/isnull(sum(qty),1) from purchase where itemautono=@ItemAutoNo and  purchasedate <convert(datetime,@FromDate,103) and unitprice>0 and qty>0 and comid=@comid


set @totalPrice=0
set @totalQty=0

select @totalPrice=isnull(sum(opValue),0) , @totalQty=isnull(sum(opbalqty),0) from item where 
autono=@ItemAutoNo  and opValue>0 and opbalqty>0 and comid=@comid and 
opbaldate <=convert(datetime,@toDate,103)

select @totalPrice= @totalPrice+ isnull(sum(totalPrice),0),@totalQty=@totalQty+isnull(sum(qty),0) from purchase where itemautono=@ItemAutoNo and
 purchasedate <=convert(datetime,@toDate,103) and unitprice>0 and qty>0 and comid=@comid

--select @ClosingUnitPrice=isnull(sum(totalPrice),0)/isnull(sum(qty),1) from purchase where itemautono=@ItemAutoNo and purchasedate <=convert(datetime,@toDate,103) and unitprice>0 and qty>0 and comid=@comid

if @totalQty<>0
begin
set @ClosingUnitPrice=@totalPrice/@totalQty
end

    
--set @UnitPrice=@ClosingUnitPrice

--set @closingUnitPrice=@OpeningUnitPrice

update stockrpt set inqty=@inqty,outqty=@outqty,retqty=@retqty,damqty=@damqty,
OpeningUnitPrice=@OpeningUnitPrice,ClosingUnitPrice=@closingUnitPrice,openingTotalPrice=opbal * @OpeningUnitPrice
, ClosingTotalPrice = (opbal+@inqty+@retqty-@outqty - @damqty) * @closingUnitPrice where itemautono=@ItemAutoNo
 and pcname=@PCName and comid=@ComID

insert temUnitPrice(comid,pcname,unitprice,ItemAutoNO) values (@comid,@pcname,@ClosingUnitPrice,@itemAutoNo)


Fetch Next from curSalary into @itemAutoNo



if @@Error <> 0
		Begin
		Rollback Transaction
		Raiserror('Insertion Failed',16,1)
		Return -1
		End	
	End
Deallocate cursalary



GO
/****** Object:  StoredProcedure [dbo].[SPUnitPriceNew]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE  PROCEDURE [dbo].[SPUnitPriceNew]

	 @PCName varchar(100)
	,@comID varchar(50)
,@fromDate varchar(10)
,@ToDate VarChar(10)

	
As

--exec SPUnitPriceNew '','1','13/03/2019','01/04/2019'

declare @ItemAutoNo int,@inqty money,@outqty money,@retqty money,@damqty money,@ClosingUnitPrice money
,@openingUnitPrice money,@unitPrice money,@totalPrice money,@totalQty money,@UserID varchar(50)

--closing qty
delete from stockrpt --where pcname=@pcname

insert stockrpt (ItemAutoNo,inhandqty,comid,usercode,pcname)
select itemautono,isnull(sum(qtyin),0)-isnull(sum(qtyout),0)-isnull(sum(damqty),0)+isnull(sum(retqty),0),comid,'leon',@pcname
from vwstock where thedate <=convert(datetime,@Todate,103) and comid='1' group by itemAutoNo,comid
--end closing qty

--select * from vwstock
--select * from stockrpt

--opening unit price
delete from temunitprice where pcname=@pcname

insert temunitprice (ItemAutoNo,OpTotPurQty,comid,pcname)
select itemautono,isnull(sum(qtyin),0)-isnull(sum(qtyout),0)-isnull(sum(damqty),0)+isnull(sum(retqty),0),comid,@pcname
from vwstock where thedate <convert(datetime,@fromdate,103) and comid='1' group by itemAutoNo,comid

update stockrpt set opbal=t.OpTotPurQty from temUnitPrice t where stockrpt.itemautono=t.itemautono 
and stockrpt.pcname=t.pcname and stockrpt.pcname=@pcname

delete from temunitprice where pcname=@pcname
insert temunitprice (itemautono,optotprice,OpTotPurQty,pcname,comid)
select autono,opvalue,opbalqty,@pcname,'1' from item where opbaldate< convert(datetime,@fromdate,103)

update stockrpt set OpTotPurQty=t.OpTotPurQty,openingTotalPrice=t.opTotPrice from temUnitPrice t where stockrpt.itemautono=t.itemautono and stockrpt.pcname=t.pcname
and stockrpt.pcname=@pcname

delete from temunitprice where pcname=@pcname
insert temunitprice (itemautono,optotprice,OpTotPurQty,pcname,comid)
select itemAutono,sum(totalprice),sum(qty),@pcname,'1' from vwpurchase where purchasedate<convert(datetime,@fromdate,103)
group by itemautono

update stockrpt set OpTotPurQty = stockrpt.OpTotPurQty + t.OpTotPurQty,openingTotalPrice=stockrpt.openingTotalPrice + t.opTotPrice 
from temUnitPrice t where stockrpt.itemautono=t.itemautono and stockrpt.pcname=t.pcname
and stockrpt.pcname=@pcname 

update stockrpt set openingUnitPrice=openingTotalPrice / OpTotPurQty where pcname=@pcname AND OpTotPurQty>0
update stockrpt set openingTotalPrice=openingUnitPrice * opbal where pcname=@pcname




---closing unit price

delete from temunitprice where pcname=@pcname
insert temunitprice (itemautono,optotprice,opTotPurQty,pcname,comid)
select autono,opvalue,opbalqty,@pcname,'1' from item where opbaldate<=convert(datetime,@Todate,103)

update stockrpt set ClTotPurQty=t.OpTotPurQty,ClosingTotalPrice=t.opTotPrice from temUnitPrice t where stockrpt.itemautono=t.itemautono and stockrpt.pcname=t.pcname
and stockrpt.pcname=@pcname


delete from temunitprice where pcname=@pcname
insert temunitprice (itemautono,optotprice,OpTotPurQty,pcname,comid)
select itemAutono,sum(totalprice),sum(qty),@pcname,'1' from vwpurchase where purchasedate<=convert(datetime,@Todate,103)
group by itemautono


update stockrpt set ClTotPurQty = stockrpt.clTotPurQty + t.OpTotPurQty,closingTotalPrice=stockrpt.closingTotalPrice + t.opTotPrice 
from temUnitPrice t where stockrpt.itemautono=t.itemautono and stockrpt.pcname=t.pcname
and stockrpt.pcname=@pcname 

 
update stockrpt set closingUnitPrice=closingTotalPrice / ClTotPurQty where pcname=@pcname and ClTotPurQty>0
update stockrpt set closingTotalPrice=closingUnitPrice * inHandQty where pcname=@pcname

--delete from stockrpt where itemautono in (select autono from item where stockMaintain=1)
--select * from stockrpt

/*
select * from temunitprice
select * from stockrpt

select * from vwpurchase
alter table stockRpt add OpTotPurQty money not null default 0
alter table stockRpt add ClTotPurQty money not null default 0

alter table temunitprice add OpTotPurQty money not null default 0
alter table temunitprice add ClTotPurQty money not null default 0

select* from purchase

select m.AutoNo,m.PurchaseDate,m.ComId,m.PurchaseCode,p.PartyName,m.Type,m.PrjAutoNo,d.ItemAutoNo,d.Qty,d.UnitPrice,d.TotalPrice
,i.ItemCode,i.ItemName
 from Purchasemstr m,partyInfo p,Purchase d,item i
 where m.comid=p.comid and m.partyAutoNo=p.autono and m.autoNO=d.autoNoFromMstrTbl and d.itemAutoNo=i.autono and d.comid=i.comid 

select * from purchasemstr
update purchase set autonoFromMstrTbl=7 where autonofromMstrTbl=0

select * from stockrpt where itemautono=1
select * from vwstock where itemautono=1
select * from temunitprice where itemautono=1


exec SPUnitPriceNew @pcname,'1',@fromdate,'10/04/2014','leon'

	 @PCName varchar(100)
	,@comID varchar(50)
,@fromDate varchar(10)
,@ToDate VarChar(10)
,@UserID varchar(50)

*/




GO
/****** Object:  StoredProcedure [dbo].[TBProcess]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO


















CREATE PROCEDURE
[dbo].[TBProcess]
@Company varchar(10)
,@tillDAte varchar(10)
,@PCNAME VARCHAR(30)
 AS

delete from tb --WHERE PCNAME=@PCNAME -- AND COMID=@Company

insert tb select h.headname,sum(v.dr)-sum(v.cr),0,@Company,@PCNAME from head h,vwvoucher v where v.headid=h.headid and v.Comid=@Company  and v.vdate<=convert(datetime,@tilldate,103) group by h.headname having sum(v.dr)-sum(v.cr)>0
insert tb select h.headname,0, abs( sum(v.dr)-sum(v.cr)),@Company,@PCNAME from head h,vwvoucher v where v.headid=h.headid and v.Comid=@Company  and  v.vdate<=convert(datetime,@tilldate,103) group by h.headname having sum(v.dr)-sum(v.cr)<0






GO
/****** Object:  StoredProcedure [dbo].[TBProcessCur]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO











CREATE PROCEDURE
[dbo].[TBProcessCur]
@Company varchar(10)
,@FromDate varchar(10)
,@tillDAte varchar(10)
,@PCNAME VARCHAR(30)
 AS

delete from tbCur --WHERE PCNAME=@PCNAME -- AND COMID=@Company


insert tbCur select h.headname,sum(v.dr)-sum(v.cr),0,@Company,@PCNAME from head h,vwvoucher v where v.headid=h.headid and v.Comid=@Company  and v.vdate between convert(datetime,@fromdate,103) and convert(datetime,@tilldate,103) group by h.headname having sum(v.dr)-sum(v.cr)>0
insert tbCur select h.headname,0, abs( sum(v.dr)-sum(v.cr)),@Company,@PCNAME from head h,vwvoucher v where v.headid=h.headid and v.Comid=@Company  and  v.vdate between convert(datetime,@fromdate,103) and convert(datetime,@tilldate,103) group by h.headname having sum(v.dr)-sum(v.cr)<0





GO
/****** Object:  StoredProcedure [dbo].[TBProcessOPBal]    Script Date: 21/10/2020 12:45:37 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO











CREATE PROCEDURE
[dbo].[TBProcessOPBal]
@Company varchar(10)
,@tillDAte varchar(10)
,@PCNAME VARCHAR(30)
 AS

delete from tbOPBal --WHERE PCNAME=@PCNAME -- AND COMID=@Company


insert tbOPBal select h.headname,sum(v.dr)-sum(v.cr),0,@Company,@PCNAME from head h,vwvoucher v where v.headid=h.headid and v.Comid=@Company  and v.vdate<=convert(datetime,@tilldate,103) group by h.headname having sum(v.dr)-sum(v.cr)>0
insert tbOPBal select h.headname,0, abs( sum(v.dr)-sum(v.cr)),@Company,@PCNAME from head h,vwvoucher v where v.headid=h.headid and v.Comid=@Company  and  v.vdate<=convert(datetime,@tilldate,103) group by h.headname having sum(v.dr)-sum(v.cr)<0





GO
