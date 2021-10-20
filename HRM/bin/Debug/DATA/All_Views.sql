USE [ROFASHA]
GO
/****** Object:  View [dbo].[VwAdv]    Script Date: 21/10/2020 12:44:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO














CREATE view [dbo].[VwAdv]
as
select m.ComID,m.EmpId,m.EmpAutoNo,m.AdvanceCode,m.Amount,Installments as NoOfInst,InstallmentAmount as InstAmt,isnull(count(isnull(d.empid,0)),0) as NoOfInstRfnd,
isnull(sum(isnull(PaidAmount,0)),0) as RefundAmt,m.Amount-isnull(sum(isnull(PaidAmount,0)),0) as Balance from advance m left outer join advancedetails d on m.empAutoNo=d.empAutoNO 
and m.advanceCode=d.advanceCode group by m.empAutoNo,m.AdvanceCode,m.Amount,Installments,InstallmentAmount,m.ComID,m.EmpId


















GO
/****** Object:  View [dbo].[VwAdvance]    Script Date: 21/10/2020 12:44:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO














CREATE view [dbo].[VwAdvance]
as
select a.EmpID,a.AdvanceCode,a.SanctionDate as TheDate,a.Amount as Debit,0 as Credit,a.Rmk,a.EntryTime,a.ComID,a.EmpAutoNo  from advance a
Union
select a.EmpId,a.AdvanceCode,a.PayDate as Thedate,0 as Debit,PaidAmount as Credit,Paytype as Rmk,a.EntryTime,a.ComId,a.EmpAutoNo from AdvanceDetails a














GO
/****** Object:  View [dbo].[VWAdvDet]    Script Date: 21/10/2020 12:44:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO















CREATE VIEW [dbo].[VWAdvDet]
AS
SELECT a.EmpID, a.AdvanceCode, a.SanctionDate, a.Amount, 
    SUM(ad.paidAmount) AS PaidAmt, 
    a.Amount - isnull(SUM(ad.paidAmount),0) AS DueAmount,a.ComId,a.EmpAutoNo
FROM Advance a INNER JOIN
    AdvanceDetails ad ON a.AdvanceCode = ad.AdvanceCode and a.empid=ad.empid and a.comid=ad.comid
GROUP BY a.EmpID, a.AdvanceCode, a.SanctionDate, a.Amount,a.ComId,a.EmpAutoNo






















GO
/****** Object:  View [dbo].[VwAllEmp]    Script Date: 21/10/2020 12:44:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO













--drop view vwAllEmp
CREATE view [dbo].[VwAllEmp]
as
select e.EmpAutoNo,E.EmpID,E.Name as EmpName,e.JoinDate,e.ConfirmDate,e.TerminationDate,e.ResignType,
e.Type,S.Name as SectionName,d.name as DesignationName,de.name as DepartmentName,l.Name as LineName,
g.Name as GradeName,e.Shift,e.Gross,e.Basic,e.HRent,e.Medical,e.AccountNo,e.CardNo
,e.Active,e.Overtime,0 as LeftWorker,e.AttendenceBonus,e.Transport,e.MobileAllow,
e.Intensive,e.PF,e.IncomeTax,e.FatherName,e.MotherName,e.Sex,e.Age,e.MStatus,e.GrossUsd,
e.SpouseName,e.PeAddress,e.PrAddress,e.Phone,e.Blood,e.Relegion,e.Nid,e.Reference1,
e.Reference2,e.ComID,d.name as Desg,e.SLNo,e.DOB,e.JoinDateOrg,e.ConfMonth,e.Allnc,e.Gage,e.SalType
 from employee e,sectionTbl s,designation d,line l,Grade g,Department de
 where  e.sectioncode=s.sectioncode and e.designationCode=d.designationCode and e.DepartmentCode=de.DepartmentCode
and e.linecode=l.linecode and e.gradeCode=g.gradeCode








GO
/****** Object:  View [dbo].[vwBokeyaCollection]    Script Date: 21/10/2020 12:44:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[vwBokeyaCollection] as

SELECT v.ComId, v.HeadId, SUM(Dr) - SUM(Cr) as Bokeya FROM Voucher v, Head h WHERE v.HeadId = h.HeadId GROUP BY v.ComId, v.HeadId

GO
/****** Object:  View [dbo].[VwDailyAttn]    Script Date: 21/10/2020 12:44:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO













CREATE VIEW [dbo].[VwDailyAttn]
AS
SELECT     dbo.DailyAttn.*
FROM         dbo.DailyAttn




























GO
/****** Object:  View [dbo].[VwEmp]    Script Date: 21/10/2020 12:44:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO















Create View [dbo].[VwEmp]
as
select E.EmpID,E.Name,E.JoinDate,E.ConfirmDate,e.TerminationDate as ResignDate,E.Gross,D.Name as Designation,L.Name as Line,
s.Name as Section ,e.Type,e.CardNo,e.Sex,e.MStatus, e.Active,e.Phone,e.PeAddress,e.PrAddress
from Employee e,sectionTbl s,Line L,Designation d
where e.lineCode=l.CodeNO and e.SectionCode=s.CodeNo and e.DesignationCode=d.CodeNO
















GO
/****** Object:  View [dbo].[VWFromDeviceData]    Script Date: 21/10/2020 12:44:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO











CREATE view [dbo].[VWFromDeviceData]
as 
select EmpAutoNO,EmpId,SwipeDate,min(SwipeTime) as InTime,null as OutTime,min(deviceNo) AS DeviceNoIn,max(deviceNo) AS DeviceNoOut,CardNO from deviceData where deviceType='i' group by empid,swipedate,EmpAutoNO,CardNO
union
select EmpAutoNO,EmpId,SwipeDate,Null as InTime,max(SwipeTime) as OutTime,min(deviceNo) AS DeviceNoIn,max(deviceNo) AS DeviceNoOut,CardNO from deviceData where deviceType='o' group by empid,swipedate,EmpAutoNO,CardNO













GO
/****** Object:  View [dbo].[VwHead]    Script Date: 21/10/2020 12:44:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO














CREATE VIEW [dbo].[VwHead]
AS
SELECT *,CONVERT(VARCHAR, headId) AS HID
FROM Head
















GO
/****** Object:  View [dbo].[vwLadger]    Script Date: 21/10/2020 12:44:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO















CREATE view [dbo].[vwLadger] 
as 
select v.*,h.headName as 
HeadNm from voucher v ,head h where h.headid=v.headid































GO
/****** Object:  View [dbo].[vwLadgerFinal]    Script Date: 21/10/2020 12:44:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






create view [dbo].[vwLadgerFinal] 
as 
select v.*,h.headName as 
HeadNm from voucher v ,head h where h.headid=v.headid







GO
/****** Object:  View [dbo].[vwLatestPrice]    Script Date: 21/10/2020 12:44:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO







CREATE view [dbo].[vwLatestPrice]
as
--select distinct itemAutoNo,ComId,max(UnitPrice) as UnitPrice from purchase where convert(varchar,ItemAutoNo) + convert(varchar,purchaseDate,103) in (
--select convert(varchar,ItemAutoNo) + convert(varchar,max(purchaseDate),103) from purchase group by itemautono)
select  autono as itemAutoNo,ComId,latestpurchaseprice as UnitPrice from item
--group by itemAutoNo,comid








































GO
/****** Object:  View [dbo].[VwMonsalary]    Script Date: 21/10/2020 12:44:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO









CREATE view [dbo].[VwMonsalary]
as
select e.EmpAutoNo,e.Name as EmpName,e.JoinDate,e.Terminationdate
,m.ComId  ,m.EmpId  ,m.ForMonth  ,m.ForYear  ,m.Gross  ,m.Basic  ,m.HRent  ,m.Allowance  ,m.OTHour  ,m.OTAmt  ,m.AttnBonus  ,m.FBonus  ,m.AttnDay  ,m.AbsDay 
 ,m.CL  ,m.SL  ,m.EL  ,m.ML  ,m.SPL  ,m.HoliDay  ,m.LDay  ,m.LMoney  ,m.CDay  ,m.CMoney  ,m.OthersAdd  ,m.ELMoney  ,m.AdvDed  ,m.PFDedEmp  ,m.PFDedCom  
,m.AbsDed  ,m.OthersDed  ,m.TotalEarn  ,m.SectionCode  ,m.DesignationCode  ,m.LineCode  ,m.GradeCode,m.DepartmentCode  ,m.totalDed  ,m.netPay  ,m.extraOtHour 
 ,m.extraOtAmt  ,m.slDed  ,m.leftworker  ,m.tk500  ,m.tk100  ,m.tk50  ,m.tk20  ,m.tk10note  ,m.tk5  ,m.tk2note  ,m.tk1note  ,m.thedate  ,m.Fraction  ,m.Unpaid  ,m.noticepay  ,m.seperate 
,m.PFLoan  ,m.PFInt  ,m.ExtraLunchDay  ,m.ExtraLunchAmt  ,m.othersAddOt  ,m.othersDedOt 
 ,m.leftSheet  ,m.OtHrPvh  ,m.OtAmtPvh  ,m.Shift  ,m.TaDa  ,m.MeetingBill  ,m.IncomeTax  ,m.MobileBill  ,m.MotorCycle  ,m.LWPay  
,m.FacUnitId  ,m.GrossUsd  ,m.TkOneThousand  ,m.PayBasic  ,m.PayHRent  ,m.PayMedical  ,m.PayGross ,m.Type  ,m.IncDed  
,m.LWP  ,s.name as SecName  ,dp.name as DepName  ,l.name as LineName  ,ds.name as DesgName,m.Bank,m.SalGrp,m.Stamp,m.SalType,m.Medical,m.ProdQty,m.ProdAmt,m.NetPayB
,g.Name as GradeName
from employee e,monsalary m,sectionTbl s,designation ds,department dp,grade g,line l where e.empautono=m.empautono and m.sectionCode=s.SectionCode 
and m.designationCode=ds.DesignationCode and m.lineCode =l.linecode and m.departmentcode=dp.departmentcode and m.gradecode=g.gradecode












GO
/****** Object:  View [dbo].[VWParty]    Script Date: 21/10/2020 12:44:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






create view [dbo].[VWParty]
as
Select * from PartyInfo







GO
/****** Object:  View [dbo].[vwPartyInfo]    Script Date: 21/10/2020 12:44:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE VIEW [dbo].[vwPartyInfo] AS

SELECT p.PartyCode, p.PartyName, p.Address, p.MobileNo, p.AcctHead, p.ComId, h.HeadId, p.EmpId, p.ShortName 
FROM PartyInfo p, head h WHERE p.AcctHead = h.HeadName








GO
/****** Object:  View [dbo].[VwProject]    Script Date: 21/10/2020 12:44:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO









create view [dbo].[VwProject]
as
select m.AutoNo,m.PrjCode,m.PrjName,p.PartyName,m.PartyOrderNo,m.PrjStartDate,m.Type,m.Status,m.ComId,m.PrjEndDate
,d.ItemAutoNo,d.Qty,d.Rmk from projectMstr m,projectDtl d ,partyinfo p where m.autono=d.autoNoFrommstrTbl and m.partyAutoNo=p.autono










GO
/****** Object:  View [dbo].[VwPurchase]    Script Date: 21/10/2020 12:44:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO










CREATE VIEW [dbo].[VwPurchase]
as
select m.AutoNo,m.PurchaseDate,m.ComId,m.PurchaseCode,p.PartyName,m.Type,m.PrjAutoNo,d.ItemAutoNo,d.Qty,d.UnitPrice,d.TotalPrice
,i.ItemCode,i.ItemName
 from Purchasemstr m,partyInfo p,Purchase d,item i
 where m.comid=p.comid and m.partyAutoNo=p.autono and m.autoNO=d.autoNoFromMstrTbl and d.itemAutoNo=i.autono and d.comid=i.comid 














GO
/****** Object:  View [dbo].[vwPurchaseMstr]    Script Date: 21/10/2020 12:44:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE view [dbo].[vwPurchaseMstr]
as
select pur.AutoNo,PurchaseCode,pur.PurchaseDate as PurDate,cast(pur.totalPrice as Decimal(10,0)) as Amount,
cast(pur.cash as Decimal(10,0)) as CashPaid,cast(pur.Due as Decimal(10,0)) as DueAmount,s.acctHead as SupplierName,pur.Post from purchaseMstr pur,partyinfo s 
where pur.partyAutoNo=s.autono 







GO
/****** Object:  View [dbo].[VwSale]    Script Date: 21/10/2020 12:44:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO









CREATE VIEW [dbo].[VwSale]
as
select m.AutoNo,m.SaleDate,m.ComId,m.InvoiceNo,p.PartyName,m.Type,m.PrjAutoNo,d.ItemAutoNo,d.Qty,d.UnitPrice,d.TotPrice,d.slno
 from saleMstr m,partyInfo p,Sale d
 where m.partyAuto=p.autono and m.autoNO=d.autoNoFromSalemstr











GO
/****** Object:  View [dbo].[VwStock]    Script Date: 21/10/2020 12:44:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO







CREATE VIEW [dbo].[VwStock]
AS


SELECT    m.PurchaseDate AS TheDate, d.Qty AS QtyIn, 0 AS QtyOut, 0 AS DamQty, 0 AS RetQty, m.ComId, 'Purchase' AS Rmk,convert(varchar, m.PurchaseCode) AS SourceNo
,m.PartyAutoNo as PartyNo,d.ItemAutoNo,d.Entrytime
FROM         dbo.PurchaseMstr m,Purchase d where m.purchaseCode=d.purchaseCode
UNION
SELECT     m.SaleDate AS TheDate, 0 AS QtyIn, d.Qty AS QtyOut, 0 AS DamQty, 0 AS RetQty, m.ComId, 'Sale' AS Rmk, convert(varchar,m.InvoiceNo) AS SourceNo ,
PartyAuto as PartyNo,d.ItemAutoNo,d.Entrytime
FROM SaleMstr m,Sale d where m.invoiceNo=d.InvoiceNo
UNION
SELECT   damDate AS TheDate, 0 AS QtyIn, 0 AS QtyOut, qty AS DamQty, 0 AS RetQty, ComId, 'Damage' AS Rmk, Damcode AS SourceNo,0 as PartyNo,ItemAutoNo,getdate() as Entrytime
FROM         Damages
UNION
SELECT     retDate AS TheDate, 0 AS QtyIn, 0 AS QtyOut, 0 AS DamQty, RetQty, ComId, 'Sales Return' AS Rmk, RetCode AS SourceNo ,0 as PartyNo,ItemAutoNo,getdate() as Entrytime
FROM         ItemReturn
union
SELECT OpBalDate as TheDate,OpBalQty as QtyIn,0 as QtyOut,0 as DamQty,0 as RetQty,ComId,'Opening' as Rmk,convert(varchar,ItemCode) as Source,0 as PartyNo,AutoNo as ItemAutono ,getdate() as Entrytime
from item
UNION
SELECT     retDate AS TheDate, 0 AS QtyIn, 0 AS QtyOut, qty AS DamQty,0 as RetQty, ComId, 'Purchase Return' AS Rmk, RetNo AS SourceNo ,0 as PartyNo,ItemAutoNo,getdate() as Entrytime
FROM         PurchaseRet








































GO
/****** Object:  View [dbo].[VwVoucher]    Script Date: 21/10/2020 12:44:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO













CREATE view [dbo].[VwVoucher]
as
select v.VoucherNo ,vm.Vdate ,v.HeadId,h.HeadName ,v.Dr ,v.Cr ,v.Rmk ,v.Note ,v.ComId ,v.D_C ,vm.AutoNo,v.AutoNoFromMstrTbl ,vm.UserCode ,vm.PrjCode,v.Cur,v.ConvRate,v.vtype,vm.vrType
,v.notermk from voucherMstr vm,voucher v,Head h where vm.comid=v.comid and vm.autoNo=v.autoNofromMstrTbl and h.headid=v.headid and h.comid=v.comid



















GO
