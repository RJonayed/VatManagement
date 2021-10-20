USE [ROFASHA]
GO
/****** Object:  Table [dbo].[AcctType]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AcctType](
	[TypeID] [varchar](10) NOT NULL,
	[Type] [varchar](100) NOT NULL,
	[Destination] [varchar](50) NOT NULL,
	[Rmk] [varchar](50) NOT NULL,
	[ComID] [varchar](50) NOT NULL,
	[AutoNo] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_AcctType] PRIMARY KEY CLUSTERED 
(
	[Type] ASC,
	[ComID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Advance]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Advance](
	[EmpAutoNo] [numeric](18, 0) NOT NULL,
	[AdvanceCode] [varchar](20) NOT NULL,
	[EmpID] [varchar](20) NOT NULL,
	[Rmk] [varchar](50) NOT NULL,
	[SanctionDate] [datetime] NULL,
	[Amount] [money] NOT NULL,
	[Installments] [money] NOT NULL,
	[InstallmentAmount] [money] NOT NULL,
	[ComID] [varchar](10) NOT NULL,
	[UserCode] [varchar](50) NOT NULL,
	[PcName] [varchar](50) NOT NULL,
	[AutoNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[RefundStartDate] [datetime] NULL,
 CONSTRAINT [PK_Advance] PRIMARY KEY CLUSTERED 
(
	[EmpAutoNo] ASC,
	[AdvanceCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AdvanceDetails]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AdvanceDetails](
	[EmpAutoNo] [numeric](18, 0) NOT NULL,
	[AdvanceCode] [varchar](20) NOT NULL,
	[InterstPaid] [money] NOT NULL,
	[paidAmount] [money] NOT NULL,
	[PayDate] [datetime] NOT NULL,
	[EMPId] [varchar](20) NOT NULL,
	[PcName] [varchar](50) NOT NULL,
	[ComID] [varchar](10) NOT NULL,
	[UserCode] [varchar](50) NOT NULL,
	[AutoNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[Paytype] [varchar](50) NOT NULL,
	[Manual] [int] NOT NULL,
	[IsMenual] [int] NOT NULL,
 CONSTRAINT [PK_AdvanceDetails] PRIMARY KEY CLUSTERED 
(
	[EmpAutoNo] ASC,
	[AdvanceCode] ASC,
	[PayDate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AttnTxtFile]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AttnTxtFile](
	[TxtLine] [varchar](250) NULL,
	[SLnO] [int] NOT NULL,
	[DayNo] [varchar](50) NULL,
	[MonthNO] [varchar](50) NULL,
	[YearNo] [varchar](50) NULL,
	[Hr] [varchar](50) NULL,
	[Mnt] [varchar](50) NULL,
	[Snd] [varchar](50) NULL,
	[AttnDate] [datetime] NULL,
	[AttnTime] [datetime] NULL,
	[EmpId] [varchar](50) NOT NULL,
	[InOut] [varchar](10) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BARCODE]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BARCODE](
	[ITEMCODE1] [varchar](50) NOT NULL,
	[ITEMCODE2] [varchar](50) NOT NULL,
	[ITEMCODE3] [varchar](50) NOT NULL,
	[ITEMCODE4] [varchar](50) NOT NULL,
	[ITEMCODE5] [varchar](50) NOT NULL,
	[SLNO] [int] NOT NULL,
	[PCNAME] [varchar](50) NOT NULL,
	[ITEMCODE6] [varchar](100) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bill](
	[BillNo] [numeric](18, 0) NOT NULL,
	[ComId] [varchar](20) NOT NULL,
	[BillDate] [datetime] NULL,
	[ChallanNo] [numeric](18, 0) NOT NULL,
	[Rmk] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BillCollection]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BillCollection](
	[ColId] [varchar](20) NOT NULL,
	[ColDate] [datetime] NULL,
	[PartyCode] [varchar](20) NOT NULL,
	[PartyAutoNo] [varchar](20) NOT NULL,
	[Amount] [money] NOT NULL,
	[Rmk] [varchar](255) NOT NULL,
	[AutoNo] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [varchar](20) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[PcName] [varchar](20) NOT NULL,
	[ComId] [varchar](20) NOT NULL,
	[ColManId] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Bonus]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bonus](
	[EmpAutoNo] [numeric](18, 0) NOT NULL,
	[ComID] [varchar](20) NOT NULL,
	[ForMonth] [varchar](50) NOT NULL,
	[ForYear] [varchar](50) NOT NULL,
	[TheDate] [datetime] NULL,
	[Gross] [money] NOT NULL,
	[Basic] [money] NOT NULL,
	[BonusAmt] [money] NOT NULL,
	[Stmp] [money] NOT NULL,
	[Rmk] [varchar](50) NOT NULL,
	[DOE] [datetime] NULL,
	[SP] [int] NOT NULL,
	[SectionCode] [numeric](18, 0) NOT NULL,
	[DesignationCode] [numeric](18, 0) NOT NULL,
	[FName] [varchar](100) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BonusEid]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BonusEid](
	[EmpID] [varchar](6) NOT NULL,
	[ForMonth] [varchar](9) NULL,
	[ForYear] [char](4) NULL,
	[AttendenceBonus] [money] NULL,
	[FestivalBonus] [money] NOT NULL,
	[PieceRateBonus] [money] NULL,
	[gross] [money] NOT NULL,
	[SectionId] [varchar](10) NULL,
	[BlockId] [varchar](10) NULL,
	[designationId] [varchar](10) NULL,
	[PayType] [varchar](15) NULL,
	[stamp] [money] NULL,
	[status] [bit] NOT NULL,
	[NewGross] [money] NULL,
	[NewBonus] [money] NULL,
	[RestAmt] [money] NULL,
	[ConsiderDay] [money] NULL,
	[AdvPercent] [money] NULL,
	[DOP] [varchar](20) NULL,
	[DOE] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Branch]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Branch](
	[ComID] [varchar](10) NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[Bname] [varchar](200) NOT NULL,
	[Rmk] [varchar](200) NOT NULL,
	[Address] [varchar](200) NOT NULL,
	[Phone] [varchar](200) NOT NULL,
	[Email] [varchar](200) NOT NULL,
	[Rpthead] [varchar](200) NOT NULL,
	[pht] [image] NULL,
	[PcName] [varchar](50) NOT NULL,
	[UserCode] [varchar](50) NOT NULL,
	[EntryTime] [datetime] NULL,
	[AutoNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[SecCode] [varchar](50) NOT NULL,
	[BranchName] [varchar](200) NOT NULL,
	[BranchCode] [varchar](50) NOT NULL,
	[Mobile] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Branch] PRIMARY KEY CLUSTERED 
(
	[ComID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BS]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BS](
	[BStype] [varchar](50) NOT NULL,
	[Debit] [money] NOT NULL,
	[Credit] [money] NOT NULL,
	[Remarks] [varchar](50) NOT NULL,
	[Grp] [varchar](50) NOT NULL,
	[ComId] [varchar](10) NOT NULL,
	[PCName] [varchar](30) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BTest]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BTest](
	[HeadName] [varchar](100) NOT NULL,
	[Debit] [money] NOT NULL,
	[Credit] [money] NOT NULL,
	[Grp] [varchar](50) NOT NULL,
	[ComId] [varchar](10) NOT NULL,
	[PCName] [varchar](30) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Class]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Class](
	[ClassID] [varchar](10) NOT NULL,
	[ClassName] [varchar](100) NOT NULL,
	[Rmk] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Class] PRIMARY KEY CLUSTERED 
(
	[ClassID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ClassInfo]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ClassInfo](
	[ClassCode] [numeric](18, 0) NOT NULL,
	[ClassName] [varchar](100) NOT NULL,
	[Duration] [money] NOT NULL,
	[Fees] [money] NOT NULL,
	[Curriculam] [varchar](300) NOT NULL,
	[Rmk] [varchar](100) NOT NULL,
	[ComID] [varchar](10) NOT NULL,
	[SGroup] [varchar](100) NOT NULL,
 CONSTRAINT [PK_ClassInfo] PRIMARY KEY CLUSTERED 
(
	[ClassCode] ASC,
	[ComID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Committee]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Committee](
	[ForYear] [varchar](10) NOT NULL,
	[TOCommittee] [varchar](50) NOT NULL,
	[EDate] [datetime] NULL,
	[SLNO] [numeric](18, 0) NOT NULL,
	[Deg] [varchar](50) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Rmk] [varchar](200) NOT NULL,
	[ComID] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Committee] PRIMARY KEY CLUSTERED 
(
	[ForYear] ASC,
	[ComID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Complaint]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Complaint](
	[CId] [varchar](20) NOT NULL,
	[ComDT] [datetime] NULL,
	[CName] [varchar](100) NOT NULL,
	[Type] [varchar](50) NOT NULL,
	[Detail] [varchar](255) NOT NULL,
	[Actn] [varchar](50) NOT NULL,
	[EmpName] [varchar](100) NOT NULL,
	[ActnDT] [datetime] NULL,
	[AutoNo] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [varchar](20) NOT NULL,
	[EntryTime] [datetime] NULL,
	[PcName] [varchar](20) NOT NULL,
	[ComId] [varchar](20) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Currency]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Currency](
	[AutoNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[CurName] [varchar](50) NOT NULL,
	[Rmk] [varchar](100) NOT NULL,
	[ComID] [varchar](20) NOT NULL,
	[CurRateTk] [money] NOT NULL,
	[SLNo] [int] NOT NULL,
	[CurRateUSD] [money] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Curriculam]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Curriculam](
	[ClassID] [numeric](18, 0) NOT NULL,
	[SubID] [numeric](18, 0) NOT NULL,
	[ComID] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DAForFastPull]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DAForFastPull](
	[EmpId] [varchar](20) NOT NULL,
	[AttnDate] [datetime] NULL,
	[EmpAutoNo] [numeric](18, 0) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DailyAttn]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DailyAttn](
	[EmpAutoNo] [numeric](18, 0) NOT NULL,
	[AttnDate] [datetime] NOT NULL,
	[EmpId] [varchar](20) NOT NULL,
	[ComID] [varchar](10) NOT NULL,
	[I] [datetime] NULL,
	[O] [datetime] NULL,
	[OT] [money] NOT NULL,
	[IB] [datetime] NULL,
	[OB] [datetime] NULL,
	[OtB] [money] NOT NULL,
	[Status] [varchar](3) NOT NULL,
	[LateRmk] [varchar](10) NOT NULL,
	[HolidayRmk] [varchar](50) NOT NULL,
	[LeaveRmk] [varchar](10) NOT NULL,
	[HolidayWork] [int] NOT NULL,
	[REM] [varchar](50) NOT NULL,
	[OtHr] [money] NOT NULL,
	[OtMnt] [money] NOT NULL,
	[OtHrB] [money] NOT NULL,
	[OtMntB] [money] NOT NULL,
	[PresentQty] [int] NOT NULL,
	[AbsentQty] [int] NOT NULL,
	[LeaveQty] [int] NOT NULL,
	[LATEQTY] [int] NOT NULL,
	[HolidayQty] [int] NOT NULL,
	[HDP] [int] NOT NULL,
	[GroupID] [varchar](10) NOT NULL,
	[Device] [varchar](10) NOT NULL,
	[OtStart] [datetime] NULL,
	[WHr] [money] NOT NULL,
	[IsManualType] [varchar](10) NOT NULL,
	[TotalEmp] [int] NOT NULL,
	[Male] [int] NOT NULL,
	[Female] [int] NOT NULL,
	[MaleP] [int] NOT NULL,
	[FemaleP] [int] NOT NULL,
	[MaleA] [int] NOT NULL,
	[FemaleA] [int] NOT NULL,
	[ONIGHT] [datetime] NULL,
	[NightOT] [money] NOT NULL,
	[GblInTime] [datetime] NULL,
	[GblOutTime] [datetime] NULL,
	[GblMaxInTime] [datetime] NULL,
	[MaxOT] [money] NOT NULL,
	[SingleEntry] [int] NOT NULL,
	[OtStartB] [datetime] NULL,
	[GD] [int] NOT NULL,
	[ExtraOTHr] [money] NOT NULL,
	[LunchDayMinus] [int] NOT NULL,
	[DeviceIn] [datetime] NULL,
	[DeviceOut] [datetime] NULL,
	[UserName] [varchar](50) NOT NULL,
	[CARDNO] [varchar](10) NOT NULL,
	[REMARKS] [varchar](50) NOT NULL,
	[LunchDay] [int] NOT NULL,
	[BusDay] [int] NOT NULL,
	[AutoNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[Leave] [varchar](50) NOT NULL,
	[Late] [varchar](50) NOT NULL,
	[MaxInTime] [datetime] NULL,
	[HoliDay] [varchar](50) NOT NULL,
	[hwqty] [int] NOT NULL,
	[statusb] [varchar](50) NOT NULL,
	[CL] [int] NOT NULL,
	[EL] [int] NOT NULL,
	[ML] [int] NOT NULL,
	[SL] [int] NOT NULL,
	[WHol] [int] NOT NULL,
	[FHol] [int] NOT NULL,
	[LateMnt] [money] NOT NULL,
	[ManualRmk] [varchar](50) NOT NULL,
	[EarlyOut] [int] NOT NULL,
	[GovHoliDay] [int] NOT NULL,
	[Transport] [int] NOT NULL,
	[Lunch] [int] NOT NULL,
	[PQty] [int] NOT NULL,
	[AQty] [int] NOT NULL,
	[SQty] [int] NOT NULL,
	[NWDay] [int] NOT NULL,
	[EarlyOutQTy] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DailyCash]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DailyCash](
	[Sl] [varchar](20) NOT NULL,
	[EntDate] [datetime] NULL,
	[Type] [varchar](50) NOT NULL,
	[Des] [varchar](100) NOT NULL,
	[Amount] [money] NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[UserCode] [varchar](20) NOT NULL,
	[PcName] [varchar](20) NOT NULL,
	[ComId] [varchar](20) NOT NULL,
	[AutoNo] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DailyCashMstr]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DailyCashMstr](
	[Sl] [varchar](20) NOT NULL,
	[CashDate] [datetime] NULL,
	[TotCol] [money] NOT NULL,
	[TotPay] [money] NOT NULL,
	[CashBal] [money] NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[UserCode] [varchar](20) NOT NULL,
	[PcName] [varchar](20) NOT NULL,
	[ComId] [varchar](20) NOT NULL,
	[AutoNo] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Damages]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Damages](
	[DamCode] [varchar](50) NOT NULL,
	[ItemCode] [varchar](50) NOT NULL,
	[DamDate] [datetime] NULL,
	[Rmk] [varchar](50) NOT NULL,
	[Qty] [money] NOT NULL,
	[ComId] [varchar](10) NOT NULL,
	[ItemAutoNo] [numeric](18, 0) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[AutoNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[PCName] [varchar](100) NOT NULL,
	[AutoNoFromMstrTbl] [numeric](18, 0) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DamagesMstr]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DamagesMstr](
	[AutoNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[DamCode] [varchar](50) NOT NULL,
	[DamDate] [datetime] NULL,
	[PCName] [varchar](50) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[ComId] [varchar](10) NOT NULL,
	[Rmk] [varchar](100) NOT NULL,
	[Type] [varchar](50) NOT NULL,
 CONSTRAINT [PK_DamagesMstr] PRIMARY KEY CLUSTERED 
(
	[AutoNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[data_card]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[data_card](
	[net_no] [int] NULL,
	[node_no] [int] NULL,
	[work_no] [nvarchar](20) NULL,
	[id_no] [nvarchar](20) NULL,
	[d_card] [nvarchar](10) NULL,
	[t_card] [nvarchar](8) NULL,
	[card_no] [nvarchar](20) NULL,
	[pin_code] [nvarchar](10) NULL,
	[shift] [nvarchar](2) NULL,
	[error_code] [nvarchar](1) NULL,
	[door_status] [nvarchar](1) NULL,
	[block_no] [nvarchar](1) NULL,
	[enter] [nvarchar](1) NULL,
	[io] [nvarchar](1) NULL,
	[card_level] [nvarchar](1) NULL,
	[extend1] [nvarchar](8) NULL,
	[extend2] [nvarchar](8) NULL,
	[modified] [nvarchar](1) NULL,
	[w_card] [nvarchar](1) NULL,
	[dt_data] [nvarchar](20) NULL,
	[id_mins] [money] NULL,
	[Reader_use] [nvarchar](1) NULL,
	[Reader_no] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DAttn]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DAttn](
	[AttnDate] [datetime] NULL,
	[EmpID] [varchar](20) NOT NULL,
	[SwipeTime] [datetime] NULL,
	[DeviceNo] [varchar](10) NOT NULL,
	[AutoNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[InTime] [datetime] NULL,
	[OutTime] [datetime] NULL,
	[OTHr] [money] NOT NULL,
	[OTMnt] [money] NOT NULL,
	[OT] [money] NOT NULL,
	[Rmk] [varchar](50) NOT NULL,
	[CardNo] [varchar](20) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DDntpla]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DDntpla](
	[Col001] [varchar](255) NULL,
	[Col002] [varchar](255) NULL,
	[Col003] [varchar](255) NULL,
	[Col004] [varchar](255) NULL,
	[Col005] [varchar](255) NULL,
	[Col006] [varchar](255) NULL,
	[Col007] [varchar](255) NULL,
	[Col008] [varchar](255) NULL,
	[Col009] [varchar](255) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Department]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Department](
	[CodeNo] [numeric](18, 0) NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[Bname] [varchar](200) NOT NULL,
	[Rmk] [varchar](200) NOT NULL,
	[ComID] [varchar](10) NOT NULL,
	[PcName] [varchar](50) NOT NULL,
	[UserCode] [numeric](18, 0) NOT NULL,
	[DepartmentCode] [numeric](18, 0) IDENTITY(0,1) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[ShortName] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[DepartmentCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Designation]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Designation](
	[CodeNo] [varchar](50) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[bangDesig] [varchar](50) NULL,
	[gradeid] [varchar](5) NOT NULL,
	[LunchMoney] [money] NOT NULL,
	[FBonus] [money] NOT NULL,
	[Bname] [varchar](30) NOT NULL,
	[attnBonus] [money] NOT NULL,
	[OT] [int] NOT NULL,
	[OthersAdd] [money] NOT NULL,
	[DesigGroup] [varchar](100) NOT NULL,
	[SalaryGroup] [varchar](100) NOT NULL,
	[ComId] [varchar](50) NOT NULL,
	[designationCode] [numeric](18, 0) IDENTITY(101,1) NOT NULL,
	[Rmk] [varchar](100) NOT NULL,
	[PcName] [varchar](50) NOT NULL,
	[UserCode] [varchar](50) NOT NULL,
	[Transport] [money] NOT NULL,
	[Lunch] [money] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DeviceData]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DeviceData](
	[EMPId] [varchar](20) NOT NULL,
	[CardNo] [varchar](20) NOT NULL,
	[SwipeDateStr] [varchar](20) NOT NULL,
	[SwipeTimeStr] [varchar](20) NOT NULL,
	[SwipeDate] [datetime] NULL,
	[SwipeTime] [datetime] NULL,
	[DeviceNo] [varchar](10) NOT NULL,
	[ComId] [varchar](10) NOT NULL,
	[deviceType] [varchar](100) NOT NULL,
	[EmpAutoNo] [numeric](18, 0) NOT NULL,
	[RawData] [varchar](250) NOT NULL,
	[AutNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[InOutType] [varchar](10) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DManualAttn]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DManualAttn](
	[Empid] [varchar](20) NOT NULL,
	[Attndate] [datetime] NULL,
	[I] [datetime] NULL,
	[O] [datetime] NULL,
	[IsmanualType] [varchar](50) NOT NULL,
	[Comid] [varchar](10) NOT NULL,
	[Entrytime] [datetime] NULL,
	[EmpAutoNo] [numeric](18, 0) NOT NULL,
	[Note] [varchar](100) NOT NULL,
	[REMARKS] [varchar](100) NOT NULL,
	[UserName] [varchar](100) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Document]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Document](
	[DocNo] [numeric](18, 0) NOT NULL,
	[DocDate] [datetime] NULL,
	[DocType] [varchar](50) NOT NULL,
	[DocImage] [image] NULL,
	[autonum] [int] IDENTITY(1,1) NOT NULL,
	[ComId] [varchar](10) NOT NULL,
	[UserId] [varchar](100) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[PCName] [varchar](100) NOT NULL,
	[filename] [varchar](100) NOT NULL,
	[PartyName] [varchar](100) NOT NULL,
	[FileType] [varchar](50) NOT NULL,
	[Rmk] [varchar](200) NOT NULL,
	[DocName] [varchar](100) NOT NULL,
	[StoreCode] [int] NOT NULL,
	[Unitcode] [int] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DonnerList]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DonnerList](
	[SLNo] [numeric](18, 0) NOT NULL,
	[DonnerName] [varchar](50) NOT NULL,
	[DonationDate] [datetime] NULL,
	[Amount] [money] NOT NULL,
	[Rmk] [varchar](500) NOT NULL,
	[ComId] [varchar](10) NOT NULL,
 CONSTRAINT [PK_DonnerList] PRIMARY KEY CLUSTERED 
(
	[SLNo] ASC,
	[ComId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Education]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Education](
	[EmpAutoNo] [numeric](18, 0) NOT NULL,
	[EmpId] [varchar](20) NOT NULL,
	[EduID] [varchar](6) NOT NULL,
	[EDegree] [varchar](15) NOT NULL,
	[Institution] [varchar](20) NOT NULL,
	[SYear] [varchar](6) NOT NULL,
	[Result] [varchar](15) NOT NULL,
	[Description] [varchar](250) NOT NULL,
	[ComID] [varchar](10) NOT NULL,
	[PcName] [varchar](50) NOT NULL,
	[UserCode] [numeric](18, 0) NOT NULL,
	[AutoNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[EntryTime] [datetime] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ELCalculation]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ELCalculation](
	[EmpAutoNO] [numeric](18, 0) NOT NULL,
	[EmpId] [varchar](20) NOT NULL,
	[ForYear] [varchar](4) NOT NULL,
	[TotWorkDay] [int] NOT NULL,
	[ELDay] [money] NOT NULL,
	[Amount] [money] NOT NULL,
	[Rmk] [varchar](50) NOT NULL,
	[UserCode] [numeric](10, 0) NOT NULL,
	[PcName] [varchar](20) NOT NULL,
	[ComID] [varchar](20) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[Gross] [money] NOT NULL,
	[Basic] [money] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ELCalculationORG]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ELCalculationORG](
	[empid] [char](6) NOT NULL,
	[forMonth] [varchar](15) NOT NULL,
	[forYear] [varchar](4) NOT NULL,
	[TotWorkDay] [int] NOT NULL,
	[ELDay] [int] NOT NULL,
	[ELAmount] [money] NOT NULL,
	[basic] [money] NOT NULL,
	[ELBal] [int] NOT NULL,
	[gross] [money] NOT NULL,
	[ELAvl] [int] NOT NULL,
	[ElYr] [varchar](10) NOT NULL,
	[ElMoney] [money] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EmpID]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EmpID](
	[SlNo] [int] NOT NULL,
	[Emp1] [varchar](20) NOT NULL,
	[Emp2] [varchar](20) NOT NULL,
	[Emp3] [varchar](20) NOT NULL,
	[Emp4] [varchar](20) NOT NULL,
	[Emp5] [varchar](20) NOT NULL,
	[EmpAutoNo1] [numeric](18, 0) NOT NULL,
	[EmpAutoNo2] [numeric](18, 0) NOT NULL,
	[EmpAutoNo3] [numeric](18, 0) NOT NULL,
	[EmpAutoNo4] [numeric](18, 0) NOT NULL,
	[EmpAutoNo5] [numeric](18, 0) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EmpInfo]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EmpInfo](
	[EmpId] [varchar](20) NOT NULL,
	[EmpName] [varchar](100) NOT NULL,
	[FName] [varchar](100) NOT NULL,
	[JoinDate] [datetime] NULL,
	[MName] [varchar](100) NOT NULL,
	[Desig] [varchar](50) NOT NULL,
	[Sex] [varchar](50) NOT NULL,
	[Salary] [money] NOT NULL,
	[NID] [varchar](20) NOT NULL,
	[Rmk] [varchar](255) NOT NULL,
	[ComId] [varchar](20) NOT NULL,
	[AutoNo] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [varchar](50) NULL,
	[PcName] [varchar](50) NULL,
	[EntryTime] [datetime] NOT NULL,
	[BName] [varchar](100) NOT NULL,
	[SalaryInt] [money] NOT NULL,
	[SalaryDis] [money] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee](
	[EmpAutoNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[ComId] [varchar](10) NOT NULL,
	[EmpId] [varchar](20) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[FatherName] [varchar](50) NOT NULL,
	[MotherName] [varchar](50) NOT NULL,
	[Sex] [varchar](50) NOT NULL,
	[DOB] [datetime] NULL,
	[Age] [varchar](50) NOT NULL,
	[MStatus] [varchar](50) NOT NULL,
	[SpouseName] [varchar](50) NOT NULL,
	[PeAddress] [varchar](200) NOT NULL,
	[PrAddress] [varchar](200) NOT NULL,
	[Phone] [varchar](50) NOT NULL,
	[Blood] [varchar](20) NOT NULL,
	[Relegion] [varchar](50) NOT NULL,
	[NID] [varchar](50) NOT NULL,
	[Reference1] [varchar](50) NOT NULL,
	[Reference2] [varchar](50) NOT NULL,
	[JoinDate] [datetime] NULL,
	[ConfirmDate] [datetime] NULL,
	[Type] [varchar](50) NOT NULL,
	[DesignationCode] [numeric](18, 0) NOT NULL,
	[SectionCode] [numeric](18, 0) NOT NULL,
	[LineCode] [numeric](18, 0) NOT NULL,
	[DepartmentCode] [numeric](18, 0) NOT NULL,
	[GradeCode] [numeric](18, 0) NOT NULL,
	[Shift] [varchar](50) NOT NULL,
	[CardNo] [varchar](50) NOT NULL,
	[Basic] [money] NOT NULL,
	[Gross] [money] NOT NULL,
	[AccountNo] [varchar](50) NOT NULL,
	[HRent] [money] NOT NULL,
	[Medical] [money] NOT NULL,
	[TerminationDate] [datetime] NULL,
	[Active] [int] NOT NULL,
	[OverTime] [int] NOT NULL,
	[AttendenceBonus] [int] NOT NULL,
	[Transport] [int] NOT NULL,
	[MobileAllow] [int] NOT NULL,
	[Intensive] [int] NOT NULL,
	[PF] [int] NOT NULL,
	[IncomeTax] [int] NOT NULL,
	[Photo] [image] NULL,
	[PcName] [varchar](50) NOT NULL,
	[UserCode] [varchar](50) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[GrossUsd] [money] NOT NULL,
	[bank] [int] NOT NULL,
	[SLNo] [numeric](18, 0) NOT NULL,
	[BName] [varchar](50) NOT NULL,
	[ResignType] [varchar](50) NOT NULL,
	[Lefty] [int] NOT NULL,
	[SalType] [varchar](20) NOT NULL,
	[JoinDateOrg] [datetime] NULL,
	[BirthID] [varchar](100) NOT NULL,
	[Allnc] [money] NOT NULL,
	[confMonth] [int] NOT NULL,
	[Gage] [varchar](100) NOT NULL,
	[Status] [int] NOT NULL,
	[AttnBonusAmt] [money] NOT NULL,
	[Insp] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmpAutoNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EmployeeN]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EmployeeN](
	[EmpID] [varchar](20) NOT NULL,
	[EmpName] [varchar](30) NOT NULL,
	[FatherName] [varchar](30) NOT NULL,
	[DOB] [datetime] NULL,
	[Sex] [varchar](50) NOT NULL,
	[PAddress] [varchar](200) NOT NULL,
	[PDistrict] [varchar](40) NOT NULL,
	[MotherName] [varchar](40) NOT NULL,
	[TAddress] [varchar](200) NOT NULL,
	[TDistrict] [varchar](40) NOT NULL,
	[Division] [varchar](40) NOT NULL,
	[Phone1] [varchar](18) NOT NULL,
	[Phone2] [varchar](18) NOT NULL,
	[JoinDate] [datetime] NULL,
	[DesignationID] [varchar](50) NOT NULL,
	[SectionID] [varchar](50) NOT NULL,
	[BlockID] [varchar](50) NOT NULL,
	[Type] [varchar](13) NOT NULL,
	[GradeID] [varchar](50) NOT NULL,
	[ProvidentFund] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[IncomeTax] [int] NOT NULL,
	[OverTime] [int] NOT NULL,
	[AttendenceBonus] [int] NOT NULL,
	[FestivalBonus] [int] NOT NULL,
	[CarAvailed] [int] NOT NULL,
	[PayType] [varchar](12) NOT NULL,
	[FacUnitID] [varchar](50) NOT NULL,
	[TerminationDate] [datetime] NULL,
	[Gratuity] [int] NOT NULL,
	[BloodG] [varchar](50) NOT NULL,
	[ConfirmDate] [datetime] NULL,
	[remarks] [varchar](100) NOT NULL,
	[bname] [varchar](50) NOT NULL,
	[age] [int] NOT NULL,
	[active] [int] NOT NULL,
	[Shift] [varchar](10) NOT NULL,
	[PFStartDate] [datetime] NULL,
	[AGENEW] [varchar](50) NOT NULL,
	[cardNo] [varchar](10) NOT NULL,
	[GroupID] [varchar](10) NOT NULL,
	[rosterholiday] [int] NOT NULL,
	[Gross] [money] NOT NULL,
	[PFPaidAmt] [money] NOT NULL,
	[PFPaidOrNot] [int] NOT NULL,
	[PF] [int] NOT NULL,
	[GrossNew] [money] NOT NULL,
	[MODIFIED] [varchar](50) NOT NULL,
	[FirstGroupid] [varchar](2) NOT NULL,
	[FirstRosterHoliday] [datetime] NULL,
	[ShiftStartDate] [datetime] NULL,
	[Relegion] [varchar](10) NOT NULL,
	[PayDate] [datetime] NULL,
	[PayMode] [varchar](50) NOT NULL,
	[Benef] [varchar](50) NOT NULL,
	[Relation] [varchar](50) NOT NULL,
	[Photo] [image] NULL,
	[NID] [varchar](50) NOT NULL,
	[AcctNo] [varchar](30) NOT NULL,
	[Mobileres] [varchar](30) NULL,
	[SpouseName] [varchar](50) NULL,
	[Accountno] [varchar](30) NULL,
	[driving] [varchar](30) NULL,
	[passport] [varchar](30) NULL,
	[MobileAllow] [int] NOT NULL,
	[Intensive] [int] NOT NULL,
	[Branch] [varchar](50) NULL,
	[GrossUsd] [money] NOT NULL,
	[GrosssUsd] [money] NOT NULL,
	[MStatus] [varchar](20) NOT NULL,
	[HName] [varchar](100) NOT NULL,
	[BGMCode] [varchar](100) NOT NULL,
	[BASIC] [money] NOT NULL,
	[HRENT] [money] NOT NULL,
	[MEDICAL] [money] NOT NULL,
	[DepartmentID] [varchar](50) NOT NULL,
	[Ref1] [varchar](200) NOT NULL,
	[Ref2] [varchar](200) NOT NULL,
	[Bank] [int] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EmployeeNew]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EmployeeNew](
	[EmpID] [varchar](20) NOT NULL,
	[EmpName] [varchar](30) NOT NULL,
	[FatherName] [varchar](30) NOT NULL,
	[DOB] [datetime] NULL,
	[Sex] [varchar](50) NOT NULL,
	[PAddress] [varchar](200) NOT NULL,
	[PDistrict] [varchar](40) NOT NULL,
	[MotherName] [varchar](40) NOT NULL,
	[TAddress] [varchar](200) NOT NULL,
	[TDistrict] [varchar](40) NOT NULL,
	[Division] [varchar](40) NOT NULL,
	[Phone1] [varchar](18) NOT NULL,
	[Phone2] [varchar](18) NOT NULL,
	[JoinDate] [datetime] NULL,
	[DesignationID] [varchar](50) NOT NULL,
	[SectionID] [varchar](50) NOT NULL,
	[BlockID] [varchar](50) NOT NULL,
	[Type] [varchar](13) NOT NULL,
	[GradeID] [varchar](50) NOT NULL,
	[ProvidentFund] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[IncomeTax] [int] NOT NULL,
	[OverTime] [int] NOT NULL,
	[AttendenceBonus] [int] NOT NULL,
	[FestivalBonus] [int] NOT NULL,
	[CarAvailed] [int] NOT NULL,
	[PayType] [varchar](12) NOT NULL,
	[FacUnitID] [varchar](50) NOT NULL,
	[TerminationDate] [datetime] NULL,
	[Gratuity] [int] NOT NULL,
	[BloodG] [varchar](50) NOT NULL,
	[ConfirmDate] [datetime] NULL,
	[remarks] [varchar](100) NOT NULL,
	[bname] [varchar](50) NOT NULL,
	[age] [int] NOT NULL,
	[active] [int] NOT NULL,
	[Shift] [varchar](10) NOT NULL,
	[PFStartDate] [datetime] NULL,
	[AGENEW] [varchar](50) NOT NULL,
	[cardNo] [varchar](10) NOT NULL,
	[GroupID] [varchar](10) NOT NULL,
	[rosterholiday] [int] NOT NULL,
	[Gross] [money] NOT NULL,
	[PFPaidAmt] [money] NOT NULL,
	[PFPaidOrNot] [int] NOT NULL,
	[PF] [int] NOT NULL,
	[GrossNew] [money] NOT NULL,
	[MODIFIED] [varchar](50) NOT NULL,
	[FirstGroupid] [varchar](2) NOT NULL,
	[FirstRosterHoliday] [datetime] NULL,
	[ShiftStartDate] [datetime] NULL,
	[Relegion] [varchar](10) NOT NULL,
	[PayDate] [datetime] NULL,
	[PayMode] [varchar](50) NOT NULL,
	[Benef] [varchar](50) NOT NULL,
	[Relation] [varchar](50) NOT NULL,
	[Photo] [image] NULL,
	[NID] [varchar](50) NOT NULL,
	[AcctNo] [varchar](30) NOT NULL,
	[Mobileres] [varchar](30) NULL,
	[SpouseName] [varchar](50) NULL,
	[Accountno] [varchar](30) NULL,
	[driving] [varchar](30) NULL,
	[passport] [varchar](30) NULL,
	[MobileAllow] [int] NOT NULL,
	[Intensive] [int] NOT NULL,
	[Branch] [varchar](50) NULL,
	[GrossUsd] [money] NOT NULL,
	[GrosssUsd] [money] NOT NULL,
	[MStatus] [varchar](20) NOT NULL,
	[HName] [varchar](100) NOT NULL,
	[BGMCode] [varchar](100) NOT NULL,
	[BASIC] [money] NOT NULL,
	[HRENT] [money] NOT NULL,
	[MEDICAL] [money] NOT NULL,
	[DepartmentID] [varchar](50) NOT NULL,
	[Ref1] [varchar](200) NOT NULL,
	[Ref2] [varchar](200) NOT NULL,
	[Bank] [int] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EmpSalary]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EmpSalary](
	[EmpId] [varchar](50) NOT NULL,
	[HeadId] [varchar](50) NOT NULL,
	[Amount] [money] NOT NULL,
	[HeadName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_EmpSalary] PRIMARY KEY NONCLUSTERED 
(
	[EmpId] ASC,
	[HeadId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EmpTEm]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EmpTEm](
	[EmpID] [varchar](50) NULL,
	[EmpName] [varchar](100) NULL,
	[DojStr] [varchar](100) NULL,
	[SectionName] [varchar](100) NULL,
	[LineName] [varchar](100) NULL,
	[DesgName] [varchar](100) NULL,
	[GradeName] [varchar](100) NULL,
	[Gross] [money] NULL,
	[Rmk] [varchar](50) NULL,
	[SectionId] [varchar](50) NULL,
	[LineId] [varchar](50) NULL,
	[DesgId] [varchar](50) NULL,
	[GradeId] [varchar](50) NULL,
	[Gender] [varchar](50) NULL,
	[Type] [varchar](50) NULL,
	[ComName] [varchar](50) NULL,
	[AutoNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[DOJ] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ErrTbl]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ErrTbl](
	[AutoNO] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[EmpId] [varchar](50) NULL,
	[EmpAutoNo] [varchar](50) NULL,
	[Rmk1] [varchar](200) NULL,
	[Rmk2] [varchar](200) NULL,
	[No1] [money] NULL,
	[No2] [money] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Experience]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Experience](
	[EmpAutoNo] [numeric](18, 0) NOT NULL,
	[EmpId] [varchar](20) NOT NULL,
	[ExpID] [varchar](6) NOT NULL,
	[YearOfExp] [int] NOT NULL,
	[Skill] [varchar](12) NOT NULL,
	[Company] [varchar](25) NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[FinishDate] [datetime] NOT NULL,
	[Responsibility] [varchar](100) NOT NULL,
	[Designation] [varchar](50) NOT NULL,
	[Description] [varchar](250) NOT NULL,
	[ComID] [varchar](10) NOT NULL,
	[PcName] [varchar](50) NOT NULL,
	[UserCode] [numeric](18, 0) NOT NULL,
	[AutoNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[EntryTime] [datetime] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ExpOfPurchase]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ExpOfPurchase](
	[SLNo] [int] NOT NULL,
	[HeadName] [varchar](50) NOT NULL,
	[Amt] [money] NOT NULL,
	[PurchaseAutoNO] [numeric](18, 0) NOT NULL,
	[Rmk] [varchar](50) NOT NULL,
	[Cur] [varchar](50) NOT NULL,
	[ConvRate] [money] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FamilyInfo]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FamilyInfo](
	[EmpAutoNo] [numeric](18, 0) NOT NULL,
	[EmpId] [varchar](20) NOT NULL,
	[Spouse] [varchar](50) NOT NULL,
	[marrigeDate] [datetime] NOT NULL,
	[SlNo] [varchar](20) NOT NULL,
	[ChildName] [varchar](50) NOT NULL,
	[DOB] [datetime] NOT NULL,
	[Remarks] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FeedBack]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FeedBack](
	[AutoNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](100) NOT NULL,
	[Rmk] [varchar](200) NOT NULL,
	[Sts] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FestivalBonus]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FestivalBonus](
	[EmpAutoNo] [numeric](18, 0) NOT NULL,
	[ForMonth] [varchar](50) NOT NULL,
	[ForYear] [varchar](50) NOT NULL,
	[EmpID] [varchar](6) NOT NULL,
	[FestivalBonus] [money] NOT NULL,
	[Gross] [money] NOT NULL,
	[Basic] [money] NOT NULL,
	[DOJ] [datetime] NULL,
	[DOE] [datetime] NULL,
	[ComId] [varchar](50) NOT NULL,
	[Rmk] [varchar](50) NOT NULL,
	[Serviceday] [varchar](50) NOT NULL,
	[UserCode] [numeric](18, 0) NOT NULL,
	[PcName] [varchar](20) NOT NULL,
	[EntryTime] [datetime] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Grade]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Grade](
	[CodeNo] [numeric](18, 0) NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[Bname] [varchar](200) NOT NULL,
	[Rmk] [varchar](200) NOT NULL,
	[comid] [varchar](50) NOT NULL,
	[PcName] [varchar](50) NOT NULL,
	[UserCode] [numeric](18, 0) NOT NULL,
	[GradeCode] [numeric](18, 0) IDENTITY(101,1) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
 CONSTRAINT [PK_Grade] PRIMARY KEY CLUSTERED 
(
	[GradeCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Head]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Head](
	[HeadId] [int] IDENTITY(1,1) NOT NULL,
	[HeadName] [varchar](200) NOT NULL,
	[Type] [varchar](50) NOT NULL,
	[HGroup] [varchar](50) NOT NULL,
	[Source] [varchar](30) NOT NULL,
	[ComId] [varchar](10) NOT NULL,
	[AutoNo] [numeric](18, 0) NOT NULL,
	[Master] [varchar](20) NOT NULL,
	[PCName] [varchar](50) NOT NULL,
	[BName] [varchar](50) NOT NULL,
	[Rmk] [varchar](200) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[UserCode] [varchar](50) NOT NULL,
	[SubHead] [varchar](100) NOT NULL,
	[OPBal] [money] NOT NULL,
	[OPBalDate] [datetime] NULL,
	[TypeAutoNo] [int] NOT NULL,
 CONSTRAINT [PK_Head] PRIMARY KEY CLUSTERED 
(
	[HeadId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HolidayCalender]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HolidayCalender](
	[HMonth] [varchar](10) NOT NULL,
	[HYear] [varchar](4) NOT NULL,
	[HDate] [datetime] NULL,
	[HDay] [varchar](50) NOT NULL,
	[Reason] [varchar](250) NOT NULL,
	[FOpen] [int] NOT NULL,
	[PcName] [varchar](50) NOT NULL,
	[UserCode] [varchar](50) NOT NULL,
	[ComId] [varchar](10) NOT NULL,
	[EntryTime] [datetime] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Increment]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Increment](
	[EmpAutoNo] [numeric](18, 0) NOT NULL,
	[EmpId] [varchar](20) NOT NULL,
	[Comid] [varchar](10) NOT NULL,
	[IncDate] [datetime] NOT NULL,
	[PrevSalary] [money] NOT NULL,
	[IncPerc] [money] NOT NULL,
	[IncAmt] [money] NOT NULL,
	[ForMonth] [varchar](9) NOT NULL,
	[ForYear] [varchar](4) NOT NULL,
	[prevSalaryDol] [money] NOT NULL,
	[IncAmtDol] [money] NOT NULL,
	[BasedOn] [varchar](10) NOT NULL,
	[IncType] [varchar](50) NOT NULL,
	[Entrytime] [datetime] NOT NULL,
	[PcName] [varchar](100) NOT NULL,
	[PresDesgCode] [numeric](18, 0) NOT NULL,
	[PrevDesgCode] [numeric](18, 0) NOT NULL,
	[AttnDate] [datetime] NULL,
	[NewID] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Increment] PRIMARY KEY CLUSTERED 
(
	[EmpAutoNo] ASC,
	[Comid] ASC,
	[IncDate] ASC,
	[IncType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Initial]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Initial](
	[EmpId] [varchar](20) NULL,
	[SlNo] [varchar](20) NULL,
	[Instrument] [varchar](30) NULL,
	[Quantity] [varchar](20) NULL,
	[Remarks] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[InstitutionInfo]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[InstitutionInfo](
	[InstCode] [varchar](50) NOT NULL,
	[InstName] [varchar](200) NOT NULL,
	[EstedDate] [datetime] NULL,
	[Address] [varchar](200) NOT NULL,
	[Area] [varchar](200) NOT NULL,
	[Type] [varchar](200) NOT NULL,
	[NumberOfTeacher] [int] NOT NULL,
	[NumberOfStudent] [int] NOT NULL,
	[NumberOfEmp] [int] NOT NULL,
	[NoOfRoom] [int] NOT NULL,
	[NoOfFloor] [int] NOT NULL,
	[Histry] [varchar](500) NOT NULL,
	[Rmk] [varchar](200) NOT NULL,
	[ComId] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Item]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Item](
	[ItemCode] [varchar](50) NOT NULL,
	[ItemName] [varchar](100) NOT NULL,
	[ItemType] [varchar](100) NOT NULL,
	[ItemSize] [varchar](100) NOT NULL,
	[ItemStyle] [varchar](50) NOT NULL,
	[OpBalQty] [money] NOT NULL,
	[ROL] [money] NOT NULL,
	[OPBalDate] [datetime] NULL,
	[BarCode] [varchar](50) NOT NULL,
	[AutoNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[ComID] [varchar](10) NOT NULL,
	[UnitID] [varchar](10) NOT NULL,
	[ProfitAddWholeSale] [money] NOT NULL,
	[ProfitAddRetailSale] [money] NOT NULL,
	[stockMaintain] [int] NOT NULL,
	[PCName] [varchar](50) NOT NULL,
	[UserCode] [varchar](50) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[SalePrice] [money] NOT NULL,
	[LatestPurchasePrice] [money] NOT NULL,
	[Active] [money] NOT NULL,
	[BName] [nvarchar](100) NOT NULL,
	[Unit] [varchar](50) NOT NULL,
	[Rmk] [varchar](200) NOT NULL,
	[Color] [varchar](100) NOT NULL,
	[CurName] [varchar](50) NOT NULL,
	[Model] [varchar](100) NOT NULL,
	[Vendor] [varchar](100) NOT NULL,
	[EndUnitQty] [money] NOT NULL,
	[ManBarcode] [int] NOT NULL,
	[OpValue] [money] NOT NULL,
	[CurStock] [money] NOT NULL,
	[WholeSalePrice] [money] NOT NULL,
	[CardSalePrice] [money] NOT NULL,
	[CreditSalePrice] [money] NOT NULL,
	[MRP] [money] NOT NULL,
	[ExpDate] [datetime] NULL,
	[PrSlNo] [int] NOT NULL,
	[Warranty] [int] NOT NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[AutoNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ItemDelivery]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ItemDelivery](
	[ItemCode] [varchar](50) NOT NULL,
	[ItemDate] [datetime] NULL,
	[Qty] [money] NOT NULL,
	[DelNo] [varchar](50) NOT NULL,
	[AutoNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[EntryTime] [datetime] NULL,
	[Rmk] [varchar](50) NOT NULL,
	[ItemAutoNO] [numeric](18, 0) NOT NULL,
	[ComID] [varchar](10) NOT NULL,
	[Type] [varchar](100) NOT NULL,
	[BatchNo] [varchar](100) NOT NULL,
	[RecQty] [money] NOT NULL,
	[RetQty] [money] NOT NULL,
	[DamQty] [money] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[TotalPrice] [money] NOT NULL,
	[SLNo] [int] NOT NULL,
	[PCName] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ItemReturn]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ItemReturn](
	[RetCode] [varchar](50) NOT NULL,
	[InvoiceNo] [varchar](20) NOT NULL,
	[SLNo] [int] NOT NULL,
	[ItemCode] [varchar](20) NOT NULL,
	[RetDate] [datetime] NULL,
	[RetQty] [money] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[TotPrice] [money] NOT NULL,
	[PcName] [varchar](20) NOT NULL,
	[Rmk] [varchar](100) NOT NULL,
	[ComId] [varchar](50) NOT NULL,
	[ItemAutoNo] [numeric](18, 0) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ItemUnit]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ItemUnit](
	[UnitId] [varchar](10) NOT NULL,
	[UnitName] [varchar](50) NOT NULL,
	[Qty] [money] NOT NULL,
	[ComId] [varchar](10) NOT NULL,
	[autono] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job](
	[JobCardNo] [varchar](50) NOT NULL,
	[Orderdate] [datetime] NULL,
	[Jobdescription] [varchar](200) NOT NULL,
	[Client] [varchar](200) NOT NULL,
	[QTY] [numeric](18, 0) NOT NULL,
	[Unit] [varchar](50) NOT NULL,
	[SuppliedQty] [numeric](18, 0) NOT NULL,
	[Status] [varchar](200) NOT NULL,
	[DeliveryDate] [datetime] NULL,
	[Rmk] [varchar](200) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[JobRmk]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[JobRmk](
	[AttnDate] [datetime] NULL,
	[SectionId] [numeric](18, 0) NOT NULL,
	[Rmk] [varchar](200) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Leave]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Leave](
	[EmpAutoNo] [numeric](18, 0) NOT NULL,
	[EmpID] [varchar](20) NOT NULL,
	[TypeOFLeave] [varchar](20) NOT NULL,
	[LeaveDate] [datetime] NOT NULL,
	[WithPayOrNot] [varchar](20) NOT NULL,
	[LQty] [money] NOT NULL,
	[LIH] [money] NOT NULL,
	[HalfQty] [money] NOT NULL,
	[ComId] [varchar](10) NOT NULL,
	[UserCode] [varchar](50) NOT NULL,
	[PcName] [varchar](50) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
 CONSTRAINT [PK_Leave] PRIMARY KEY CLUSTERED 
(
	[EmpAutoNo] ASC,
	[LeaveDate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LeaveBalance]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LeaveBalance](
	[EmpAutoNO] [numeric](18, 0) NOT NULL,
	[EmpID] [varchar](20) NOT NULL,
	[ForYear] [varchar](10) NOT NULL,
	[SLAVL] [money] NOT NULL,
	[CLAVL] [money] NOT NULL,
	[ELAVL] [money] NOT NULL,
	[SLFixed] [money] NOT NULL,
	[CLFixed] [money] NOT NULL,
	[ELFixed] [money] NOT NULL,
	[CLBal] [money] NOT NULL,
	[SLBal] [money] NOT NULL,
	[ELBal] [money] NOT NULL,
	[ComId] [varchar](10) NOT NULL,
	[UserCode] [numeric](18, 0) NOT NULL,
	[PcName] [varchar](50) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
 CONSTRAINT [PK_LeaveBalance] PRIMARY KEY CLUSTERED 
(
	[EmpAutoNO] ASC,
	[ForYear] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LeaveTbl]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LeaveTbl](
	[empid] [varchar](20) NULL,
	[leaveDate] [datetime] NOT NULL,
	[typeOfLeave] [varchar](10) NULL,
	[LQty] [money] NOT NULL,
	[LType] [varchar](10) NOT NULL,
	[HalfQty] [money] NOT NULL,
	[LIH] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LeaveTransaction]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LeaveTransaction](
	[EmpAutoNO] [numeric](18, 0) NOT NULL,
	[EmpId] [varchar](20) NOT NULL,
	[TypeOfLeave] [varchar](10) NOT NULL,
	[WithPayorNot] [varchar](50) NOT NULL,
	[FromDate] [datetime] NOT NULL,
	[ToDate] [datetime] NULL,
	[TotalDays] [money] NOT NULL,
	[HalfLeave] [money] NOT NULL,
	[Remarks] [varchar](50) NOT NULL,
	[LIH] [int] NOT NULL,
	[ComId] [varchar](10) NOT NULL,
	[UserCode] [varchar](50) NOT NULL,
	[PcName] [varchar](50) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[ForYear] [varchar](10) NOT NULL,
 CONSTRAINT [PK_LeaveTransaction] PRIMARY KEY CLUSTERED 
(
	[EmpAutoNO] ASC,
	[FromDate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Line]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Line](
	[CodeNo] [numeric](18, 0) NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[BName] [varchar](200) NOT NULL,
	[Rmk] [varchar](200) NOT NULL,
	[PcName] [varchar](50) NOT NULL,
	[UserCode] [numeric](18, 0) NOT NULL,
	[ComId] [varchar](10) NOT NULL,
	[LineCode] [numeric](18, 0) IDENTITY(0,1) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[ShortName] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Line] PRIMARY KEY CLUSTERED 
(
	[LineCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOG]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOG](
	[UID] [varchar](20) NOT NULL,
	[THETIME] [datetime] NOT NULL,
	[DESCRIPTION] [varchar](200) NOT NULL,
	[PCName] [varchar](50) NOT NULL,
	[AutoNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[ComID] [varchar](10) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoginUser]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoginUser](
	[UserCode] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[ComID] [varchar](10) NOT NULL,
	[EntryTime] [datetime] NULL,
 CONSTRAINT [PK_LoginUser] PRIMARY KEY CLUSTERED 
(
	[UserCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LtrSend]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LtrSend](
	[AutoNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Address] [varchar](250) NOT NULL,
	[PcName] [varchar](200) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ManEdit]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ManEdit](
	[EmpID] [varchar](20) NOT NULL,
	[AttnDate] [datetime] NULL,
	[I] [datetime] NULL,
	[O] [datetime] NULL,
	[IsManualType] [varchar](50) NOT NULL,
	[AutoNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Rmk] [varchar](100) NOT NULL,
	[EmpAutoNo] [numeric](18, 0) NOT NULL,
	[ManualRmk] [varchar](100) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MarksEntry]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MarksEntry](
	[StudentID] [varchar](20) NOT NULL,
	[ExamName] [varchar](50) NOT NULL,
	[ComID] [varchar](10) NOT NULL,
	[SubjCode] [numeric](18, 0) NOT NULL,
	[ShortMarks] [int] NOT NULL,
	[BroadMarks] [int] NOT NULL,
	[Result] [varchar](50) NOT NULL,
	[Rmk] [varchar](50) NOT NULL,
	[PCName] [varchar](200) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[UserCode] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_MarksEntry] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC,
	[ExamName] ASC,
	[ComID] ASC,
	[SubjCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[mm]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[mm](
	[Empid] [varchar](53) NULL,
	[Wpay] [varchar](50) NULL,
	[Qty] [int] NULL,
	[Type] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MonSalary]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MonSalary](
	[EmpAutoNo] [numeric](18, 0) NOT NULL,
	[ComId] [varchar](10) NOT NULL,
	[EmpId] [varchar](20) NOT NULL,
	[ForMonth] [varchar](10) NOT NULL,
	[ForYear] [varchar](4) NOT NULL,
	[Gross] [money] NOT NULL,
	[Basic] [money] NOT NULL,
	[HRent] [money] NOT NULL,
	[Allowance] [money] NOT NULL,
	[OTHour] [money] NOT NULL,
	[OTAmt] [money] NOT NULL,
	[AttnBonus] [money] NOT NULL,
	[FBonus] [money] NOT NULL,
	[AttnDay] [int] NOT NULL,
	[AbsDay] [int] NOT NULL,
	[CL] [int] NOT NULL,
	[SL] [int] NOT NULL,
	[EL] [int] NOT NULL,
	[ML] [int] NOT NULL,
	[SPL] [int] NOT NULL,
	[HoliDay] [money] NOT NULL,
	[LDay] [int] NOT NULL,
	[LMoney] [money] NOT NULL,
	[CDay] [int] NOT NULL,
	[CMoney] [money] NOT NULL,
	[OthersAdd] [money] NOT NULL,
	[ELMoney] [money] NOT NULL,
	[AdvDed] [money] NOT NULL,
	[PFDedEmp] [money] NOT NULL,
	[PFDedCom] [money] NOT NULL,
	[AbsDed] [money] NOT NULL,
	[OthersDed] [money] NOT NULL,
	[TotalEarn] [money] NOT NULL,
	[SectionCode] [numeric](18, 0) NOT NULL,
	[DesignationCode] [numeric](18, 0) NOT NULL,
	[LineCode] [numeric](18, 0) NOT NULL,
	[GradeCode] [numeric](18, 0) NOT NULL,
	[DepartmentCode] [numeric](18, 0) NOT NULL,
	[TotalDed] [money] NOT NULL,
	[NetPay] [money] NOT NULL,
	[ExtraOtHour] [money] NOT NULL,
	[ExtraOtAmt] [money] NOT NULL,
	[SLDed] [money] NOT NULL,
	[leftworker] [int] NOT NULL,
	[tk500] [int] NOT NULL,
	[tk100] [int] NOT NULL,
	[tk50] [int] NOT NULL,
	[tk20] [int] NOT NULL,
	[tk10note] [int] NOT NULL,
	[tk5] [int] NOT NULL,
	[tk2note] [int] NOT NULL,
	[tk1note] [int] NOT NULL,
	[thedate] [datetime] NULL,
	[Fraction] [money] NOT NULL,
	[Unpaid] [int] NOT NULL,
	[UNPAIDOT] [int] NOT NULL,
	[noticepay] [money] NOT NULL,
	[seperate] [int] NOT NULL,
	[TEM1] [int] NOT NULL,
	[SalGrp] [varchar](50) NOT NULL,
	[Bank] [int] NOT NULL,
	[PFLoan] [money] NOT NULL,
	[PFInt] [money] NOT NULL,
	[ExtraLunchDay] [int] NOT NULL,
	[ExtraLunchAmt] [money] NOT NULL,
	[othersAddOt] [money] NOT NULL,
	[othersDedOt] [money] NOT NULL,
	[leftSheet] [int] NOT NULL,
	[OtHrPvh] [money] NOT NULL,
	[OtAmtPvh] [money] NOT NULL,
	[GrossB] [money] NOT NULL,
	[OThourB] [money] NOT NULL,
	[OTAmtB] [money] NOT NULL,
	[PFdedEmpB] [money] NOT NULL,
	[TotalEarnB] [money] NOT NULL,
	[NetPayB] [money] NOT NULL,
	[DesigIDB] [varchar](10) NOT NULL,
	[GradeIDB] [varchar](10) NOT NULL,
	[absdedB] [money] NOT NULL,
	[TotalDedB] [money] NOT NULL,
	[Paytype] [varchar](20) NOT NULL,
	[GD] [int] NOT NULL,
	[ATTNDayB] [int] NOT NULL,
	[HDayB] [int] NOT NULL,
	[AbsDayb] [int] NOT NULL,
	[Shift] [varchar](20) NOT NULL,
	[TaDa] [money] NOT NULL,
	[MeetingBill] [money] NOT NULL,
	[IncomeTax] [money] NOT NULL,
	[MobileBill] [money] NOT NULL,
	[MotorCycle] [money] NOT NULL,
	[LWPay] [money] NOT NULL,
	[FacUnitId] [varchar](10) NOT NULL,
	[GrosssUsd] [money] NOT NULL,
	[GrossUsd] [money] NOT NULL,
	[TkOneThousand] [int] NOT NULL,
	[PayBasic] [money] NOT NULL,
	[PayHRent] [money] NOT NULL,
	[PayMedical] [money] NOT NULL,
	[PayGross] [money] NOT NULL,
	[Type] [varchar](20) NOT NULL,
	[IncDed] [money] NOT NULL,
	[LWP] [int] NOT NULL,
	[UserCode] [numeric](18, 0) NOT NULL,
	[PcName] [varchar](50) NOT NULL,
	[Entrytime] [datetime] NOT NULL,
	[MonthDay] [int] NOT NULL,
	[WorkDay] [int] NOT NULL,
	[SalaryDay] [int] NOT NULL,
	[GovHoliDay] [int] NOT NULL,
	[PageSlNo] [int] NOT NULL,
	[Stamp] [money] NOT NULL,
	[Medical] [money] NOT NULL,
	[OTRate] [money] NOT NULL,
	[ExtraOTRate] [money] NOT NULL,
	[TA] [money] NOT NULL,
	[Food] [money] NOT NULL,
	[IncAmt] [money] NOT NULL,
	[PayAbleSalary] [money] NOT NULL,
	[SalType] [varchar](100) NOT NULL,
	[BasicB] [money] NOT NULL,
	[HRentB] [money] NOT NULL,
	[MedicalB] [money] NOT NULL,
	[ProdAmt] [money] NOT NULL,
	[ProdQty] [money] NOT NULL,
	[SrNo] [int] NOT NULL,
	[OffDay] [int] NOT NULL,
 CONSTRAINT [PK_MonSalary] PRIMARY KEY CLUSTERED 
(
	[ComId] ASC,
	[EmpId] ASC,
	[ForMonth] ASC,
	[ForYear] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MonthlyAttn]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MonthlyAttn](
	[EmpAutoNo] [numeric](18, 0) NOT NULL,
	[ForMonth] [varchar](20) NOT NULL,
	[ForYear] [varchar](10) NOT NULL,
	[EmpId] [varchar](20) NOT NULL,
	[ComId] [varchar](10) NOT NULL,
	[TotAttnDay] [money] NOT NULL,
	[OTHr] [money] NOT NULL,
	[ExtraOT] [money] NOT NULL,
	[TotHoliday] [money] NOT NULL,
	[OthersAdd] [money] NOT NULL,
	[OthersDeduct] [money] NOT NULL,
	[AddRmk] [varchar](50) NOT NULL,
	[DeductRmk] [varchar](50) NOT NULL,
	[PCName] [varchar](200) NOT NULL,
	[UserCode] [numeric](18, 0) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[Manual] [int] NOT NULL,
	[OTAdd] [money] NOT NULL,
	[OTDed] [money] NOT NULL,
	[Transport] [int] NOT NULL,
 CONSTRAINT [PK_MonthlyAttn] PRIMARY KEY CLUSTERED 
(
	[EmpAutoNo] ASC,
	[ForMonth] ASC,
	[ForYear] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MonthlyPcsEntry]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MonthlyPcsEntry](
	[ForMonth] [varchar](10) NOT NULL,
	[ForYear] [varchar](10) NOT NULL,
	[EmpAutoNo] [numeric](18, 0) NOT NULL,
	[StyleAutoNo] [numeric](18, 0) NOT NULL,
	[Qty] [money] NOT NULL,
	[Rate] [money] NOT NULL,
	[PCName] [varchar](50) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[UserCode] [varchar](50) NOT NULL,
	[ComID] [varchar](20) NOT NULL,
	[Total] [money] NOT NULL,
	[TheDate] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MonthlySetup]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MonthlySetup](
	[ForMonth] [varchar](20) NOT NULL,
	[ForYear] [varchar](4) NOT NULL,
	[DollarRate] [money] NOT NULL,
	[FDate] [datetime] NULL,
	[LDate] [datetime] NULL,
	[MDays] [int] NOT NULL,
	[MNo] [int] NOT NULL,
	[ComID] [varchar](10) NOT NULL,
	[AutoNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[SPLock] [int] NOT NULL,
	[ForMonthBangla] [varchar](100) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MonthlyTbl]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MonthlyTbl](
	[ForYear] [varchar](50) NOT NULL,
	[ForMonth] [varchar](50) NOT NULL,
	[MonthNo] [int] NOT NULL,
	[MonthDays] [int] NOT NULL,
	[DollarRate] [money] NOT NULL,
	[BName] [varchar](20) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OTEdit]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OTEdit](
	[EmpID] [varchar](50) NOT NULL,
	[AttnDate] [datetime] NULL,
	[OT] [numeric](18, 0) NOT NULL,
	[Typ] [varchar](50) NOT NULL,
	[OTStart] [datetime] NULL,
	[Hol] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PartyBranch]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PartyBranch](
	[PartyAutoNo] [char](10) NULL,
	[SLNo] [int] NOT NULL,
	[BranchName] [varchar](100) NOT NULL,
	[Address] [varchar](200) NOT NULL,
	[ContPerson] [varchar](100) NOT NULL,
	[Phone] [varchar](50) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[UserCode] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PartyInfo]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PartyInfo](
	[PartyCode] [varchar](50) NOT NULL,
	[PartyName] [varchar](100) NOT NULL,
	[Address] [varchar](200) NOT NULL,
	[PartyType] [varchar](100) NOT NULL,
	[MobileNo] [varchar](100) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[ContactPerson] [varchar](100) NOT NULL,
	[AcctHead] [varchar](100) NOT NULL,
	[RMK] [varchar](200) NOT NULL,
	[ContractMoney] [money] NOT NULL,
	[Adv] [money] NOT NULL,
	[Due] [money] NOT NULL,
	[ComId] [varchar](30) NOT NULL,
	[PayMode] [varchar](20) NOT NULL,
	[AutoNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[PayDate] [datetime] NULL,
	[Master] [varchar](20) NOT NULL,
	[DisPerc] [money] NOT NULL,
	[DrCr] [varchar](10) NOT NULL,
	[OPBal] [money] NOT NULL,
	[OpBalDate] [datetime] NULL,
	[EntryTime] [datetime] NULL,
	[PCName] [varchar](100) NOT NULL,
	[UserCode] [varchar](50) NOT NULL,
	[CrLimit] [money] NOT NULL,
	[PassportNo] [varchar](100) NOT NULL,
	[DrvLiscNo] [varchar](100) NOT NULL,
	[PhoneNo] [varchar](100) NOT NULL,
	[CurName] [varchar](50) NOT NULL,
	[ShortName] [varchar](50) NOT NULL,
	[BillMonth] [varchar](100) NOT NULL,
	[sts] [varchar](10) NOT NULL,
	[ActFrom] [datetime] NULL,
	[InActFrom] [datetime] NULL,
	[EmpId] [varchar](20) NOT NULL,
	[BName] [varchar](100) NOT NULL,
	[AreaCode] [varchar](50) NOT NULL,
	[RoadNo] [varchar](50) NOT NULL,
	[SlNo] [int] NOT NULL,
 CONSTRAINT [PK_PartyInfo] PRIMARY KEY CLUSTERED 
(
	[AutoNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Photo]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Photo](
	[ComId] [varchar](10) NOT NULL,
	[EmpId] [varchar](20) NOT NULL,
	[Photo] [image] NULL,
	[EmpAutoNo] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_Photo] PRIMARY KEY CLUSTERED 
(
	[ComId] ASC,
	[EmpId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PODtl]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PODtl](
	[AutoNoFromMstrTbl] [int] NOT NULL,
	[ItemName] [varchar](100) NOT NULL,
	[ItemAutoNo] [numeric](18, 0) NOT NULL,
	[ComId] [varchar](10) NOT NULL,
	[Qty] [money] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[TotalPrice] [money] NOT NULL,
	[Rmk] [varchar](100) NOT NULL,
	[PCName] [varchar](100) NOT NULL,
	[UserCode] [varchar](50) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[slNo] [int] NOT NULL,
	[ItemCode] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[POMstr]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[POMstr](
	[ComId] [varchar](10) NOT NULL,
	[PONo] [varchar](50) NOT NULL,
	[PODate] [datetime] NULL,
	[SupplierName] [varchar](100) NOT NULL,
	[SupplierAddress] [varchar](200) NOT NULL,
	[PartyAutoNo] [numeric](10, 0) NOT NULL,
	[AutoNO] [int] IDENTITY(1,1) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[UserCode] [varchar](50) NOT NULL,
	[PCName] [varchar](50) NOT NULL,
	[Rmk] [varchar](100) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Project]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Project](
	[PrjCode] [varchar](20) NOT NULL,
	[PrjName] [varchar](200) NOT NULL,
	[Rmk] [varchar](250) NOT NULL,
	[Type] [varchar](100) NOT NULL,
	[PrjStartDate] [datetime] NULL,
	[AutoNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[ComID] [varchar](10) NOT NULL,
	[UserCode] [varchar](50) NOT NULL,
	[PCName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED 
(
	[PrjCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProjectDtl]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProjectDtl](
	[AutoNoFromMstrTbl] [numeric](18, 0) NOT NULL,
	[ComID] [varchar](20) NOT NULL,
	[SlNo] [numeric](18, 0) NOT NULL,
	[ItemAutoNo] [numeric](18, 0) NOT NULL,
	[Qty] [money] NOT NULL,
	[Rmk] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProjectMstr]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProjectMstr](
	[PrjCode] [varchar](20) NOT NULL,
	[PrjName] [varchar](200) NOT NULL,
	[Rmk] [varchar](250) NOT NULL,
	[Type] [varchar](100) NOT NULL,
	[PrjStartDate] [datetime] NULL,
	[AutoNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[ComID] [varchar](10) NOT NULL,
	[PartyAutoNo] [numeric](18, 0) NOT NULL,
	[Status] [int] NOT NULL,
	[PartyOrderNo] [int] NOT NULL,
	[PartyOrderDate] [datetime] NULL,
	[UserCode] [varchar](50) NOT NULL,
	[PCName] [varchar](50) NOT NULL,
	[PrjEndDate] [datetime] NULL,
	[ExpectedFinDate] [datetime] NULL,
 CONSTRAINT [PK_ProjectMstr] PRIMARY KEY CLUSTERED 
(
	[AutoNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Purchase]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Purchase](
	[PurchaseCode] [numeric](18, 0) NOT NULL,
	[ItemCode] [varchar](50) NOT NULL,
	[PurchaseDate] [datetime] NULL,
	[PartyCode] [varchar](50) NOT NULL,
	[Qty] [money] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[SalePrice] [money] NOT NULL,
	[ExprDate] [datetime] NULL,
	[SalePriceCode] [varchar](50) NOT NULL,
	[UserCode] [varchar](50) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[PCName] [varchar](50) NOT NULL,
	[SlNo] [int] NOT NULL,
	[Barcode] [varchar](50) NOT NULL,
	[TotalPrice] [money] NOT NULL,
	[PSlNo] [varchar](50) NOT NULL,
	[ComId] [varchar](20) NOT NULL,
	[ItemAutoNo] [numeric](18, 0) NOT NULL,
	[ManualBarcode] [int] NOT NULL,
	[WholeSalePrice] [money] NOT NULL,
	[AutoBarCode] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[UID] [varchar](50) NOT NULL,
	[AutoNoFromMstrTbl] [numeric](18, 0) NOT NULL,
	[Rmk] [varchar](250) NOT NULL,
	[UserId] [varchar](50) NOT NULL,
	[Type] [varchar](50) NOT NULL,
	[WrntySts] [int] NOT NULL,
	[Cur] [varchar](50) NOT NULL,
	[ConvRate] [money] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PurchaseMstr]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PurchaseMstr](
	[PurchaseCode] [numeric](18, 0) NOT NULL,
	[PurchaseDate] [datetime] NOT NULL,
	[Rmk] [varchar](50) NOT NULL,
	[TotalPrice] [money] NOT NULL,
	[PCNAME] [varchar](50) NOT NULL,
	[ENTRYTIME] [datetime] NOT NULL,
	[UserCode] [varchar](50) NOT NULL,
	[COMID] [varchar](10) NOT NULL,
	[CASH] [money] NOT NULL,
	[DUE] [money] NOT NULL,
	[Post] [varchar](20) NOT NULL,
	[MemoNo] [varchar](50) NOT NULL,
	[AutoNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[PrjCode] [varchar](20) NOT NULL,
	[PartyAutoNo] [numeric](18, 0) NOT NULL,
	[UserId] [varchar](50) NOT NULL,
	[FactoryExp] [int] NOT NULL,
	[Type] [varchar](50) NOT NULL,
	[PrjAutoNo] [numeric](18, 0) NOT NULL,
	[VrNo] [varchar](100) NOT NULL,
	[ConvRate] [money] NOT NULL,
	[oRDERNO] [varchar](50) NOT NULL,
	[CrHead] [varchar](100) NOT NULL,
 CONSTRAINT [PK_PurchaseMstr] PRIMARY KEY CLUSTERED 
(
	[AutoNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PurchaseRet]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PurchaseRet](
	[RetNo] [varchar](50) NOT NULL,
	[PurchaseCode] [int] NOT NULL,
	[ItemAutoNo] [int] NOT NULL,
	[Qty] [money] NOT NULL,
	[RetDate] [datetime] NULL,
	[Rmk] [varchar](200) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[PCName] [varchar](50) NOT NULL,
	[UserCode] [varchar](50) NOT NULL,
	[ComId] [varchar](10) NOT NULL,
	[AutoNo] [int] IDENTITY(1,1) NOT NULL,
	[reason] [varchar](200) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Quotation]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Quotation](
	[AutoNoFromMstrTbl] [numeric](18, 0) NOT NULL,
	[ItemName] [varchar](50) NOT NULL,
	[SlNo] [numeric](18, 0) NOT NULL,
	[Qty] [numeric](18, 0) NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[TotPrice] [money] NOT NULL,
	[Rmk] [varchar](100) NOT NULL,
	[ComID] [varchar](20) NOT NULL,
	[PcName] [varchar](30) NOT NULL,
	[UserCode] [varchar](20) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QuotationMstr]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QuotationMstr](
	[AutoNo] [numeric](18, 0) IDENTITY(101,1) NOT NULL,
	[QutNo] [varchar](20) NOT NULL,
	[QutDate] [datetime] NULL,
	[CusName] [varchar](50) NOT NULL,
	[Designation] [varchar](50) NOT NULL,
	[Address] [varchar](100) NOT NULL,
	[PhoneNo] [varchar](50) NOT NULL,
	[Subject] [varchar](100) NOT NULL,
	[ComID] [varchar](20) NOT NULL,
	[PcName] [varchar](30) NOT NULL,
	[UserCode] [varchar](20) NOT NULL,
	[DiscussDate] [datetime] NULL,
	[PaymentTerms] [text] NOT NULL,
	[SMC] [nvarchar](500) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RateEntry]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RateEntry](
	[AutoNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[SLNo] [varchar](50) NOT NULL,
	[Stl] [varchar](50) NOT NULL,
	[Sz] [varchar](50) NOT NULL,
	[Rate] [money] NOT NULL,
	[Rmk] [varchar](100) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[UserCode] [varchar](50) NOT NULL,
	[ComId] [varchar](20) NOT NULL,
	[PCName] [varchar](50) NOT NULL,
	[Body] [varchar](100) NOT NULL,
	[Sec] [varchar](100) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Requisition]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Requisition](
	[PrjAutoNo] [numeric](18, 0) NOT NULL,
	[SlNo] [numeric](18, 0) NOT NULL,
	[ItemAutoNo] [numeric](18, 0) NOT NULL,
	[Qty] [money] NOT NULL,
	[Rmk] [varchar](50) NOT NULL,
	[ComID] [varchar](20) NOT NULL,
	[ReqDate] [datetime] NULL,
	[AutoNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Responsibility]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Responsibility](
	[EmpID] [varchar](10) NULL,
	[SL] [varchar](10) NULL,
	[Description] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ResultSheet]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ResultSheet](
	[SID] [varchar](50) NOT NULL,
	[ClassCode] [varchar](50) NOT NULL,
	[ExamName] [varchar](50) NOT NULL,
	[Gpa] [money] NOT NULL,
	[ComId] [varchar](10) NOT NULL,
	[ForMonth] [varchar](20) NOT NULL,
	[ForYear] [varchar](20) NOT NULL,
	[BM] [int] NOT NULL,
	[SM] [int] NOT NULL,
	[CT] [int] NOT NULL,
	[Sec] [varchar](20) NOT NULL,
	[SubjCode] [varchar](20) NOT NULL,
	[Grade] [varchar](20) NOT NULL,
	[TotSubject] [int] NOT NULL,
	[TotGpa] [money] NOT NULL,
	[ResGpa] [money] NOT NULL,
	[RollNo] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SalBeforeProcess]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SalBeforeProcess](
	[EmpId] [varchar](50) NOT NULL,
	[ForMonth] [varchar](50) NOT NULL,
	[ForYear] [varchar](50) NOT NULL,
	[PayDate] [datetime] NULL,
	[Amount] [money] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sale]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sale](
	[InvoiceNo] [numeric](10, 0) NOT NULL,
	[SLNo] [int] NOT NULL,
	[SaleDate] [datetime] NULL,
	[Qty] [money] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[TotPrice] [money] NOT NULL,
	[PurchaseCode] [int] NOT NULL,
	[PcName] [varchar](50) NOT NULL,
	[CusName] [varchar](200) NOT NULL,
	[ComId] [varchar](30) NOT NULL,
	[AutoNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[ItemAutoNo] [numeric](18, 0) NOT NULL,
	[Barcode] [varchar](50) NOT NULL,
	[AutoNoFromSaleMstr] [numeric](18, 0) NOT NULL,
	[UserCode] [varchar](50) NOT NULL,
	[Rmk] [varchar](200) NOT NULL,
	[Type] [varchar](50) NOT NULL,
	[Roll] [money] NOT NULL,
	[DiaGz] [money] NOT NULL,
	[Cur] [int] NOT NULL,
	[ConvRate] [money] NOT NULL,
	[ItemCode] [varchar](10) NOT NULL,
	[Hide] [int] NOT NULL,
	[PayAble] [int] NOT NULL,
	[TotDis] [int] NOT NULL,
	[SaleType] [varchar](50) NOT NULL,
	[PrSlNo] [varchar](255) NOT NULL,
	[Warranty] [int] NOT NULL,
	[WarType] [varchar](20) NOT NULL,
	[LastPurPrice] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SaleMstr]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SaleMstr](
	[InvoiceNo] [numeric](10, 0) NOT NULL,
	[SaleDate] [datetime] NULL,
	[ComId] [varchar](10) NOT NULL,
	[Total] [money] NOT NULL,
	[Due] [money] NOT NULL,
	[Discount] [money] NOT NULL,
	[Payable] [money] NOT NULL,
	[Refund] [money] NOT NULL,
	[Rmk] [varchar](250) NOT NULL,
	[Vat] [money] NOT NULL,
	[PartyAuto] [numeric](18, 0) NOT NULL,
	[PCNAME] [varchar](50) NOT NULL,
	[Paymode] [varchar](50) NOT NULL,
	[CardNo] [numeric](18, 0) NOT NULL,
	[BankName] [varchar](200) NOT NULL,
	[Paid] [money] NOT NULL,
	[TotVat] [money] NOT NULL,
	[DisPer] [money] NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[UserCode] [varchar](50) NOT NULL,
	[CashAmt] [money] NOT NULL,
	[CardAmt] [money] NOT NULL,
	[SaleType] [varchar](200) NOT NULL,
	[InstAmt1] [money] NOT NULL,
	[InstAmt2] [money] NOT NULL,
	[InstAmt3] [money] NOT NULL,
	[IntPerc] [money] NOT NULL,
	[INTaMT] [money] NOT NULL,
	[AutoNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[PrjCode] [varchar](20) NOT NULL,
	[Type] [varchar](200) NOT NULL,
	[PrjAutoNo] [numeric](18, 0) NOT NULL,
	[MenoNo] [varchar](20) NOT NULL,
	[AutoRmk] [varchar](200) NOT NULL,
	[InvSubmitDate] [datetime] NULL,
	[Footer] [nvarchar](500) NOT NULL,
	[Header] [varchar](250) NOT NULL,
	[ConvRate] [money] NOT NULL,
	[CrHeadId] [varchar](100) NOT NULL,
	[CusName] [varchar](200) NOT NULL,
	[CusMobile] [varchar](200) NOT NULL,
 CONSTRAINT [PK_SaleMstr] PRIMARY KEY CLUSTERED 
(
	[AutoNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SalesOrder]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SalesOrder](
	[AutoNoFromMstrTbl] [numeric](18, 0) NOT NULL,
	[SlNo] [numeric](18, 0) NOT NULL,
	[ItemAutoNo] [numeric](18, 0) NOT NULL,
	[Qty] [numeric](18, 0) NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[TotPrice] [money] NULL,
	[Rmk] [varchar](50) NOT NULL,
	[ComId] [varchar](20) NOT NULL,
	[UserCode] [varchar](20) NOT NULL,
	[PcName] [varchar](20) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SalesOrderMstr]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SalesOrderMstr](
	[AutoNo] [numeric](18, 0) IDENTITY(101,1) NOT NULL,
	[OrderNo] [varchar](50) NOT NULL,
	[OrderDate] [datetime] NULL,
	[CusName] [varchar](50) NOT NULL,
	[Address] [varchar](100) NOT NULL,
	[PhoneNo] [varchar](50) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[ComID] [varchar](10) NOT NULL,
	[UserCode] [varchar](20) NOT NULL,
	[PcName] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SalStyle]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SalStyle](
	[Style] [varchar](50) NOT NULL,
	[Gross] [money] NOT NULL,
	[Basic] [money] NOT NULL,
	[HRent] [money] NOT NULL,
	[Medical] [money] NOT NULL,
	[Conv] [money] NOT NULL,
	[Food] [money] NOT NULL,
	[Others] [money] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Scan]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Scan](
	[EmpAutoNo] [numeric](18, 0) NOT NULL,
	[EmpId] [varchar](20) NOT NULL,
	[Pht1] [image] NULL,
	[Pht2] [image] NULL,
	[Pht3] [image] NULL,
	[Pht4] [image] NULL,
	[Pht5] [image] NULL,
	[Pht6] [image] NULL,
	[Pht7] [image] NULL,
	[Pht8] [image] NULL,
	[Pht9] [image] NULL,
	[Pht10] [image] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Section]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Section](
	[SectionID] [varchar](50) NOT NULL,
	[Section] [varchar](25) NOT NULL,
	[GroupId] [varchar](6) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SectionTbl]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SectionTbl](
	[CodeNo] [numeric](18, 0) NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[BName] [varchar](200) NOT NULL,
	[Rmk] [varchar](200) NOT NULL,
	[PcName] [varchar](50) NOT NULL,
	[UserCode] [numeric](18, 0) NOT NULL,
	[ComId] [varchar](10) NOT NULL,
	[SectionCode] [numeric](18, 0) IDENTITY(101,1) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[ShortName] [varchar](10) NOT NULL,
 CONSTRAINT [PK_SectionTbl] PRIMARY KEY CLUSTERED 
(
	[SectionCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Security]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Security](
	[UserCode] [numeric](18, 0) NOT NULL,
	[SCREEN] [varchar](100) NOT NULL,
	[s] [int] NOT NULL,
	[d] [int] NOT NULL,
	[v] [int] NOT NULL,
	[e] [int] NOT NULL,
	[Rmk] [varchar](100) NOT NULL,
	[ComID] [varchar](10) NOT NULL,
	[UID] [varchar](50) NOT NULL,
	[Sw] [int] NOT NULL,
	[Kn] [int] NOT NULL,
	[Hrm] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Setting]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Setting](
	[SalaryStyle] [varchar](50) NOT NULL,
	[PhotoPath] [varchar](200) NOT NULL,
	[DollarRate] [int] NOT NULL,
	[BackImage] [int] NOT NULL,
	[PcName] [varchar](50) NOT NULL,
	[UserCode] [varchar](50) NOT NULL,
	[ComID] [varchar](10) NOT NULL,
	[AutoNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[TextFilePath] [varchar](200) NOT NULL,
	[Topp] [int] NOT NULL,
	[Heightt] [int] NOT NULL,
	[Leftt] [int] NOT NULL,
	[Widthh] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SettingSingle]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SettingSingle](
	[VatPerc] [money] NOT NULL,
	[CommonItem] [int] NOT NULL,
	[CommonParty] [int] NOT NULL,
	[AutoNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[PhotoPath] [varchar](250) NOT NULL,
	[VAT] [money] NOT NULL,
	[ExDate] [datetime] NULL,
	[RMSPath] [varchar](200) NOT NULL,
	[HandKey] [int] NOT NULL,
	[LockDate] [datetime] NOT NULL,
	[InvoiceBig] [int] NOT NULL,
	[AutoGenEmpId] [int] NOT NULL,
	[SalaryStyle] [varchar](100) NOT NULL,
	[ComID] [varchar](10) NOT NULL,
	[SHOWPWD] [varchar](100) NOT NULL,
	[HIDEPWD] [varchar](100) NOT NULL,
	[PickSalePriceFromPur] [int] NOT NULL,
	[envFrom] [varchar](200) NOT NULL,
	[envTo] [varchar](200) NOT NULL,
	[dontPrintInvoice] [int] NOT NULL,
	[ChProPrice] [int] NOT NULL,
	[BtnDelInvoice] [varchar](20) NOT NULL,
	[SaleFormLocationX] [varchar](20) NOT NULL,
	[SaleFormLocationY] [varchar](20) NOT NULL,
	[PayMode] [varchar](20) NOT NULL,
	[NuhashGL] [varchar](20) NOT NULL,
	[MobiileNo] [varchar](255) NOT NULL,
	[MobileNo] [varchar](255) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ShiftSet]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ShiftSet](
	[FromDate] [datetime] NOT NULL,
	[ToDate] [datetime] NOT NULL,
	[GroupID] [varchar](10) NOT NULL,
	[EmpID] [varchar](20) NOT NULL,
	[HDate] [datetime] NULL,
	[ForMonth] [varchar](10) NOT NULL,
	[ForYear] [varchar](4) NOT NULL,
	[WeekName] [varchar](50) NULL,
	[PCNAME] [varchar](50) NOT NULL,
	[USERCODE] [numeric](18, 0) NOT NULL,
	[ENTRYTIME] [datetime] NOT NULL,
	[ComID] [varchar](10) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SMSSent]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SMSSent](
	[AutoNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[MobileNo] [varchar](200) NOT NULL,
	[MsgBody] [varchar](250) NOT NULL,
	[ContactName] [varchar](200) NOT NULL,
	[Rmk] [varchar](200) NOT NULL,
	[EntryTime] [datetime] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Stock]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Stock](
	[ItemCode] [varchar](20) NOT NULL,
	[ItemName] [varchar](20) NOT NULL,
	[ItemType] [varchar](20) NOT NULL,
	[ItemSize] [varchar](50) NOT NULL,
	[INQty] [numeric](19, 4) NOT NULL,
	[OutQty] [numeric](19, 4) NOT NULL,
	[PDate] [datetime] NULL,
	[DQty] [numeric](18, 0) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StockRpt]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StockRpt](
	[ItemCode] [varchar](50) NOT NULL,
	[ComID] [varchar](10) NOT NULL,
	[OPBal] [money] NOT NULL,
	[InQty] [money] NOT NULL,
	[OutQty] [money] NOT NULL,
	[DamQty] [money] NOT NULL,
	[RetQty] [money] NOT NULL,
	[InHandQty] [money] NOT NULL,
	[OpeningUnitPrice] [money] NOT NULL,
	[OpeningTotalPrice] [money] NOT NULL,
	[UserCode] [varchar](50) NOT NULL,
	[ItemAutoNo] [numeric](18, 0) NOT NULL,
	[ProfitWholeSale] [money] NOT NULL,
	[ProfitRetailSale] [money] NOT NULL,
	[PCName] [varchar](50) NOT NULL,
	[ClosingUnitPrice] [money] NOT NULL,
	[ClosingTotalPrice] [money] NOT NULL,
	[totalPrice] [money] NOT NULL,
	[OpTotPurQty] [money] NOT NULL,
	[ClTotPurQty] [money] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Student]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Student](
	[ComId] [varchar](10) NOT NULL,
	[StudentID] [varchar](20) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[FatherName] [varchar](100) NOT NULL,
	[MotherName] [varchar](100) NOT NULL,
	[GuardianName] [varchar](100) NOT NULL,
	[GuardianRelation] [varchar](100) NOT NULL,
	[Sex] [varchar](10) NOT NULL,
	[DOB] [datetime] NULL,
	[PeAddress] [varchar](200) NOT NULL,
	[PrAddress] [varchar](200) NOT NULL,
	[Phone] [varchar](50) NOT NULL,
	[Blood] [varchar](20) NOT NULL,
	[Relegion] [varchar](20) NOT NULL,
	[NID] [varchar](50) NOT NULL,
	[Reference1] [varchar](100) NOT NULL,
	[Reference2] [varchar](100) NOT NULL,
	[FirstAddmissionDate] [datetime] NULL,
	[CardNo] [varchar](50) NOT NULL,
	[TerminationDate] [datetime] NULL,
	[Active] [int] NOT NULL,
	[Transport] [int] NOT NULL,
	[Photo] [image] NULL,
	[PcName] [varchar](50) NOT NULL,
	[UserCode] [varchar](50) NOT NULL,
	[AutnoNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[EntryTime] [datetime] NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[ComId] ASC,
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Subject](
	[ComId] [varchar](10) NOT NULL,
	[CodeNo] [numeric](18, 0) NOT NULL,
	[Class] [varchar](50) NOT NULL,
	[SubjectName] [varchar](100) NOT NULL,
	[ShortMarksTotal] [int] NOT NULL,
	[BroadMarksTotal] [int] NOT NULL,
	[ShortMarksPass] [int] NOT NULL,
	[BroadMarksPass] [int] NOT NULL,
	[Rmk] [varchar](50) NOT NULL,
	[EntryTime] [datetime] NULL,
	[PCName] [varchar](50) NOT NULL,
	[UserCode] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED 
(
	[ComId] ASC,
	[CodeNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Swipe]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Swipe](
	[Empid] [varchar](50) NOT NULL,
	[AttnDate] [datetime] NULL,
	[SwipeTime] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB](
	[HEADNAME] [varchar](200) NOT NULL,
	[DEBIT] [money] NOT NULL,
	[CREDIT] [money] NOT NULL,
	[COMID] [varchar](10) NOT NULL,
	[PCNAME] [varchar](30) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBCur]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBCur](
	[HEADNAME] [varchar](200) NOT NULL,
	[DEBIT] [money] NOT NULL,
	[CREDIT] [money] NOT NULL,
	[COMID] [varchar](10) NOT NULL,
	[PCNAME] [varchar](30) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBOpBal]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBOpBal](
	[HEADNAME] [varchar](200) NOT NULL,
	[DEBIT] [money] NOT NULL,
	[CREDIT] [money] NOT NULL,
	[COMID] [varchar](10) NOT NULL,
	[PCNAME] [varchar](30) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TeacherInfo]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TeacherInfo](
	[TID] [varchar](10) NOT NULL,
	[TName] [varchar](50) NOT NULL,
	[FName] [varchar](50) NOT NULL,
	[MName] [varchar](50) NOT NULL,
	[PresentAddress] [varchar](50) NOT NULL,
	[ParmanentAddress] [varchar](50) NOT NULL,
	[DOB] [datetime] NULL,
	[NIDNo] [varchar](50) NOT NULL,
	[ContactNo] [varchar](20) NOT NULL,
	[Nationality] [varchar](20) NOT NULL,
	[Religion] [varchar](20) NOT NULL,
	[Gender] [varchar](20) NOT NULL,
	[Photo] [image] NULL,
	[ComId] [varchar](10) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[PcName] [varchar](50) NOT NULL,
	[UserCode] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_TeacherInfo] PRIMARY KEY CLUSTERED 
(
	[TID] ASC,
	[ComId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TeachersInfo]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TeachersInfo](
	[ComID] [varchar](10) NOT NULL,
	[CodeNo] [numeric](18, 0) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[FName] [varchar](50) NOT NULL,
	[MName] [varchar](50) NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[DOB] [datetime] NULL,
	[BloodG] [varchar](50) NOT NULL,
	[InterviewDate] [varchar](50) NOT NULL,
	[CircularDate] [varchar](50) NOT NULL,
	[AddMediaName] [varchar](50) NOT NULL,
	[BoardMember] [varchar](50) NOT NULL,
	[GovtRepresentative] [varchar](50) NOT NULL,
	[InterviewResult] [varchar](50) NOT NULL,
	[DOJ] [datetime] NULL,
	[SelectedForSub] [varchar](50) NOT NULL,
	[MPO] [varchar](50) NOT NULL,
	[TypeOfTeacher] [varchar](50) NOT NULL,
	[Paddress] [varchar](50) NOT NULL,
	[Phone] [varchar](18) NOT NULL,
	[Nation] [varchar](50) NOT NULL,
	[Religious] [varchar](50) NOT NULL,
	[Sex] [varchar](50) NOT NULL,
	[NIdNo] [varchar](50) NOT NULL,
	[Dropout] [int] NOT NULL,
	[DropOutDate] [datetime] NULL,
 CONSTRAINT [PK_TeachersInfo] PRIMARY KEY CLUSTERED 
(
	[ComID] ASC,
	[CodeNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tem]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tem](
	[rmk] [varchar](200) NULL,
	[entrytime] [datetime] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TemAdvance]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TemAdvance](
	[empid] [varchar](50) NOT NULL,
	[Formonth] [varchar](50) NOT NULL,
	[forYear] [varchar](50) NOT NULL,
	[AdvDed] [money] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TemBarcode]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TemBarcode](
	[B1] [varchar](100) NOT NULL,
	[B2] [varchar](100) NOT NULL,
	[B3] [varchar](100) NOT NULL,
	[B4] [varchar](100) NOT NULL,
	[B5] [varchar](100) NOT NULL,
	[Name1] [varchar](100) NOT NULL,
	[Name2] [varchar](100) NOT NULL,
	[Name3] [varchar](100) NOT NULL,
	[Name4] [varchar](100) NOT NULL,
	[Name5] [varchar](100) NOT NULL,
	[P1] [varchar](100) NOT NULL,
	[P2] [varchar](100) NOT NULL,
	[P3] [varchar](100) NOT NULL,
	[P4] [varchar](100) NOT NULL,
	[P5] [varchar](100) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TemEmp]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TemEmp](
	[EmpID] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TemForItemRpt]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TemForItemRpt](
	[ItemAutoNo] [int] NOT NULL,
	[Amt] [money] NOT NULL,
	[PCName] [varchar](100) NOT NULL,
	[ItemCode] [varchar](50) NOT NULL,
	[ComId] [varchar](20) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TemItemLadger]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TemItemLadger](
	[PrjAutoNo] [numeric](18, 0) NOT NULL,
	[TheDate] [datetime] NULL,
	[ItemAutoNo] [numeric](18, 0) NOT NULL,
	[ReqQty] [money] NOT NULL,
	[InQty] [money] NOT NULL,
	[OutQty] [money] NOT NULL,
	[Balance] [money] NOT NULL,
	[PcName] [varchar](20) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TemKnit]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TemKnit](
	[BrName] [varchar](100) NOT NULL,
	[LotNo] [varchar](100) NOT NULL,
	[InputPrev] [money] NOT NULL,
	[InputToday] [money] NOT NULL,
	[InputTotal] [money] NOT NULL,
	[OutputPrev] [money] NOT NULL,
	[OutputToday] [money] NOT NULL,
	[OutputTotal] [money] NOT NULL,
	[ShipMentPrev] [money] NOT NULL,
	[ShipMentToday] [money] NOT NULL,
	[ShipMentTotal] [money] NOT NULL,
	[ShipmentBalance] [money] NOT NULL,
	[FBalance] [money] NOT NULL,
	[YBalance] [money] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TemKnit2]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TemKnit2](
	[BrName] [varchar](100) NOT NULL,
	[LotNo] [varchar](100) NOT NULL,
	[Qty] [money] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TemLadger]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TemLadger](
	[VDate] [datetime] NULL,
	[VoucherNO] [varchar](50) NOT NULL,
	[HeadId] [varchar](100) NOT NULL,
	[HeadName] [varchar](100) NOT NULL,
	[Debit] [money] NOT NULL,
	[Credit] [money] NOT NULL,
	[NoteRmk] [varchar](200) NOT NULL,
	[Rmk] [varchar](200) NOT NULL,
	[PCName] [varchar](50) NOT NULL,
	[Remarks] [varchar](200) NOT NULL,
	[Note] [varchar](200) NOT NULL,
	[SLNo] [int] NOT NULL,
	[OpBal] [money] NOT NULL,
	[ClBal] [money] NOT NULL,
	[Balance] [money] NOT NULL,
	[UserCode] [varchar](20) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TemRpt]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TemRpt](
	[ItemCode] [nvarchar](50) NULL,
	[PurchaseQty] [money] NULL,
	[PurchasePrice] [money] NULL,
	[SaleQty] [money] NULL,
	[SalePrice] [money] NULL,
	[Profit] [money] NULL,
	[LastUnitPrice] [money] NULL,
	[PCName] [varchar](100) NOT NULL,
	[ItemAutoNo] [numeric](18, 0) NOT NULL,
	[ComId] [varchar](10) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TemSalProcess]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TemSalProcess](
	[EmpID] [varchar](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TemStockWithPrice]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TemStockWithPrice](
	[PCName] [varchar](50) NOT NULL,
	[ItemAutoNo] [numeric](18, 0) NOT NULL,
	[OpeningStockQty] [money] NOT NULL,
	[OpeningStockPrice] [money] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[QtyIn] [money] NOT NULL,
	[QtyOut] [money] NOT NULL,
	[ClosingStockQty] [money] NOT NULL,
	[ClosingStockPrice] [money] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TemTradAc]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TemTradAc](
	[Head] [varchar](50) NOT NULL,
	[SubHead] [varchar](50) NOT NULL,
	[HeadAmtDr] [money] NOT NULL,
	[HeadAmtCr] [money] NOT NULL,
	[SHDr] [money] NOT NULL,
	[SHCr] [money] NOT NULL,
	[AutoNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Rmk] [varchar](50) NOT NULL,
	[PCName] [varchar](50) NOT NULL,
	[SLNo] [int] NOT NULL,
	[ComID] [varchar](50) NOT NULL,
	[Type] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TemUnitPrice]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TemUnitPrice](
	[ItemAutoNO] [numeric](18, 0) NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[ComID] [varchar](50) NOT NULL,
	[PCName] [varchar](50) NOT NULL,
	[OpTotPrice] [money] NOT NULL,
	[ClosingTotPrice] [money] NOT NULL,
	[OpTotPurQty] [money] NOT NULL,
	[ClTotPurQty] [money] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TemVoucher]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TemVoucher](
	[UserCode] [varchar](50) NOT NULL,
	[VNo] [varchar](50) NOT NULL,
	[HeadName] [varchar](50) NOT NULL,
	[HeadID] [varchar](50) NOT NULL,
	[Dr] [money] NOT NULL,
	[Cr] [money] NOT NULL,
	[Note] [varchar](200) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[PCName] [varchar](50) NOT NULL,
	[AutoNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[ComId] [varchar](20) NOT NULL,
	[D_C] [varchar](20) NOT NULL,
	[AutoNoFromMstrTbl] [numeric](18, 0) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TimeGroup]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TimeGroup](
	[GroupID] [varchar](30) NOT NULL,
	[NameRpt] [varchar](50) NOT NULL,
	[InTime] [datetime] NULL,
	[OutTime] [datetime] NULL,
	[MaxInTime] [datetime] NULL,
	[Setupdate] [datetime] NOT NULL,
	[InTimeStartFrom] [datetime] NULL,
	[MaxOT] [money] NOT NULL,
	[OTStart] [datetime] NULL,
	[PcName] [varchar](50) NOT NULL,
	[UserCode] [numeric](18, 0) NOT NULL,
	[ComId] [varchar](10) NOT NULL,
	[AutoNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[LunchMnt] [money] NOT NULL,
 CONSTRAINT [PK_TimeGroup] PRIMARY KEY CLUSTERED 
(
	[GroupID] ASC,
	[Setupdate] ASC,
	[ComId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TKT]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TKT](
	[SLNo] [int] NOT NULL,
	[TheDate] [datetime] NULL,
	[Status] [varchar](20) NOT NULL,
	[Amount] [money] NOT NULL,
	[Rmk] [varchar](200) NOT NULL,
	[PurchaseAmt] [money] NOT NULL,
	[SaleAmt] [money] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tm]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tm](
	[autono] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[tm] [datetime] NULL,
	[tmP] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TOKENNO]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TOKENNO](
	[ComId] [varchar](10) NOT NULL,
	[EmpID] [varchar](20) NOT NULL,
	[TOKENNO] [varchar](10) NOT NULL,
	[FromDate] [datetime] NOT NULL,
	[ToDate] [datetime] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tution]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tution](
	[ClassCode] [varchar](50) NOT NULL,
	[Sid] [varchar](50) NOT NULL,
	[Fees] [money] NOT NULL,
	[Paid] [money] NOT NULL,
	[Due] [money] NOT NULL,
	[Refund] [money] NOT NULL,
	[ForMonth] [varchar](50) NOT NULL,
	[ForYear] [varchar](50) NOT NULL,
	[PaymentDate] [datetime] NULL,
	[Rmk] [varchar](50) NOT NULL,
	[ComID] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TV]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TV](
	[COMPANY] [nvarchar](50) NULL,
	[TVID] [nvarchar](200) NULL,
	[RMK] [nvarchar](200) NULL,
	[AutoNo] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserVoucher]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserVoucher](
	[ComID] [varchar](20) NOT NULL,
	[UserCode] [varchar](20) NOT NULL,
	[VNo] [varchar](20) NOT NULL,
	[VDate] [datetime] NULL,
	[HeadName] [varchar](200) NOT NULL,
	[Dr] [money] NOT NULL,
	[Cr] [money] NOT NULL,
	[Note] [varchar](200) NOT NULL,
	[Type] [varchar](200) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Voucher]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Voucher](
	[VoucherNo] [varchar](20) NOT NULL,
	[Vdate] [datetime] NULL,
	[HeadId] [int] NOT NULL,
	[Dr] [money] NOT NULL,
	[Cr] [money] NOT NULL,
	[Rmk] [varchar](200) NOT NULL,
	[VType] [varchar](100) NOT NULL,
	[Note] [varchar](200) NOT NULL,
	[SlNo] [varchar](10) NOT NULL,
	[ComId] [varchar](10) NOT NULL,
	[Amount] [money] NOT NULL,
	[D_C] [varchar](10) NOT NULL,
	[AutoRmk] [varchar](200) NOT NULL,
	[AutoNo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[HeadId2] [numeric](18, 0) NOT NULL,
	[CustomerId] [varchar](100) NOT NULL,
	[PCName] [varchar](50) NOT NULL,
	[AutoNoFromMstrTbl] [numeric](18, 0) NOT NULL,
	[UserCode] [varchar](50) NOT NULL,
	[NoteRmk] [varchar](200) NOT NULL,
	[Cur] [varchar](50) NOT NULL,
	[ConvRate] [money] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VoucherMstr]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VoucherMstr](
	[AutoNo] [numeric](18, 0) IDENTITY(10000,1) NOT NULL,
	[PCName] [varchar](100) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[VDate] [datetime] NULL,
	[PrjCode] [varchar](20) NOT NULL,
	[UserCode] [varchar](50) NOT NULL,
	[VoucherNo] [varchar](20) NOT NULL,
	[AutoRmk] [varchar](200) NOT NULL,
	[ComID] [varchar](10) NOT NULL,
	[PrjAutoNo] [numeric](18, 0) NOT NULL,
	[Cur] [varchar](100) NOT NULL,
	[ConvRate] [money] NOT NULL,
	[VrType] [varchar](100) NOT NULL,
 CONSTRAINT [PK_VoucherMstr] PRIMARY KEY CLUSTERED 
(
	[AutoNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VoucherNo]    Script Date: 21/10/2020 12:42:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VoucherNo](
	[VoucherNo] [numeric](18, 0) IDENTITY(10000,1) NOT NULL,
	[PCName] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[AcctType] ADD  CONSTRAINT [DF__AcctType__TypeID__304F08CE]  DEFAULT ('') FOR [TypeID]
GO
ALTER TABLE [dbo].[AcctType] ADD  CONSTRAINT [DF__AcctType__Type__31432D07]  DEFAULT ('') FOR [Type]
GO
ALTER TABLE [dbo].[AcctType] ADD  CONSTRAINT [DF__AcctType__Destin__32375140]  DEFAULT ('') FOR [Destination]
GO
ALTER TABLE [dbo].[AcctType] ADD  CONSTRAINT [DF__AcctType__Rmk__332B7579]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[Advance] ADD  CONSTRAINT [DF_Advance_EmpAutoNo]  DEFAULT (0) FOR [EmpAutoNo]
GO
ALTER TABLE [dbo].[Advance] ADD  CONSTRAINT [DF_Advance_AdvanceID]  DEFAULT ('') FOR [AdvanceCode]
GO
ALTER TABLE [dbo].[Advance] ADD  CONSTRAINT [DF_Advance_EmpID]  DEFAULT ('') FOR [EmpID]
GO
ALTER TABLE [dbo].[Advance] ADD  CONSTRAINT [DF_Advance_AdvanceDetails]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[Advance] ADD  CONSTRAINT [DF_Advance_Amount]  DEFAULT (0) FOR [Amount]
GO
ALTER TABLE [dbo].[Advance] ADD  CONSTRAINT [DF_Advance_Installments]  DEFAULT (0) FOR [Installments]
GO
ALTER TABLE [dbo].[Advance] ADD  CONSTRAINT [DF_Advance_InstallmentAmount]  DEFAULT (0) FOR [InstallmentAmount]
GO
ALTER TABLE [dbo].[Advance] ADD  CONSTRAINT [DF_Advance_ComID]  DEFAULT ('') FOR [ComID]
GO
ALTER TABLE [dbo].[Advance] ADD  CONSTRAINT [DF_Advance_UserCode]  DEFAULT ('') FOR [UserCode]
GO
ALTER TABLE [dbo].[Advance] ADD  CONSTRAINT [DF_Advance_PcName]  DEFAULT ('') FOR [PcName]
GO
ALTER TABLE [dbo].[Advance] ADD  CONSTRAINT [DF_Advance_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[AdvanceDetails] ADD  CONSTRAINT [DF_AdvanceDetails_EmpAutoNo]  DEFAULT (0) FOR [EmpAutoNo]
GO
ALTER TABLE [dbo].[AdvanceDetails] ADD  CONSTRAINT [DF_AdvanceDetails_AdvanceID]  DEFAULT ('') FOR [AdvanceCode]
GO
ALTER TABLE [dbo].[AdvanceDetails] ADD  CONSTRAINT [DF_AdvanceDetails_InterstPaid]  DEFAULT (0) FOR [InterstPaid]
GO
ALTER TABLE [dbo].[AdvanceDetails] ADD  CONSTRAINT [DF_AdvanceDetails_paidAmount]  DEFAULT (0) FOR [paidAmount]
GO
ALTER TABLE [dbo].[AdvanceDetails] ADD  CONSTRAINT [DF_AdvanceDetails_EMPId]  DEFAULT ('') FOR [EMPId]
GO
ALTER TABLE [dbo].[AdvanceDetails] ADD  CONSTRAINT [DF_AdvanceDetails_PcName]  DEFAULT ('') FOR [PcName]
GO
ALTER TABLE [dbo].[AdvanceDetails] ADD  CONSTRAINT [DF_AdvanceDetails_ComID]  DEFAULT ('') FOR [ComID]
GO
ALTER TABLE [dbo].[AdvanceDetails] ADD  CONSTRAINT [DF_AdvanceDetails_UserName]  DEFAULT ('') FOR [UserCode]
GO
ALTER TABLE [dbo].[AdvanceDetails] ADD  CONSTRAINT [DF_AdvanceDetails_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[AdvanceDetails] ADD  CONSTRAINT [DF_AdvanceDetails_Paytype]  DEFAULT ('') FOR [Paytype]
GO
ALTER TABLE [dbo].[AdvanceDetails] ADD  CONSTRAINT [DF_AdvanceDetails_Manual]  DEFAULT (0) FOR [Manual]
GO
ALTER TABLE [dbo].[AdvanceDetails] ADD  CONSTRAINT [DF__advanceDe__IsMen__0432261C]  DEFAULT (0) FOR [IsMenual]
GO
ALTER TABLE [dbo].[AttnTxtFile] ADD  CONSTRAINT [DF_AttnTxtFile_SLnO]  DEFAULT (0) FOR [SLnO]
GO
ALTER TABLE [dbo].[AttnTxtFile] ADD  CONSTRAINT [DF_AttnTxtFile_EmpId]  DEFAULT ('') FOR [EmpId]
GO
ALTER TABLE [dbo].[AttnTxtFile] ADD  CONSTRAINT [DF_AttnTxtFile_InOut]  DEFAULT ('') FOR [InOut]
GO
ALTER TABLE [dbo].[BARCODE] ADD  CONSTRAINT [DF_BARCODE_ITEMCODE1]  DEFAULT ('') FOR [ITEMCODE1]
GO
ALTER TABLE [dbo].[BARCODE] ADD  CONSTRAINT [DF_BARCODE_ITEMCODE2]  DEFAULT ('') FOR [ITEMCODE2]
GO
ALTER TABLE [dbo].[BARCODE] ADD  CONSTRAINT [DF_BARCODE_ITEMCODE3]  DEFAULT ('') FOR [ITEMCODE3]
GO
ALTER TABLE [dbo].[BARCODE] ADD  CONSTRAINT [DF_BARCODE_ITEMCODE4]  DEFAULT ('') FOR [ITEMCODE4]
GO
ALTER TABLE [dbo].[BARCODE] ADD  CONSTRAINT [DF_BARCODE_ITEMCODE5]  DEFAULT ('') FOR [ITEMCODE5]
GO
ALTER TABLE [dbo].[BARCODE] ADD  CONSTRAINT [DF_BARCODE_SLNO]  DEFAULT (0) FOR [SLNO]
GO
ALTER TABLE [dbo].[BARCODE] ADD  CONSTRAINT [DF_BARCODE_PCNAME]  DEFAULT ('') FOR [PCNAME]
GO
ALTER TABLE [dbo].[BARCODE] ADD  CONSTRAINT [DF__barcode__ITEMCOD__4BE214AA]  DEFAULT ('') FOR [ITEMCODE6]
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF_Bill_BillNo]  DEFAULT (0) FOR [BillNo]
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF_Bill_ComId]  DEFAULT ('') FOR [ComId]
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF_Bill_ChallanNo]  DEFAULT (0) FOR [ChallanNo]
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF_Bill_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[BillCollection] ADD  CONSTRAINT [DF__BillColle__ColId__2F6FF32E]  DEFAULT ('') FOR [ColId]
GO
ALTER TABLE [dbo].[BillCollection] ADD  CONSTRAINT [DF__BillColle__Party__30641767]  DEFAULT ('') FOR [PartyCode]
GO
ALTER TABLE [dbo].[BillCollection] ADD  CONSTRAINT [DF__BillColle__Party__31583BA0]  DEFAULT ('') FOR [PartyAutoNo]
GO
ALTER TABLE [dbo].[BillCollection] ADD  CONSTRAINT [DF__BillColle__Amoun__324C5FD9]  DEFAULT (0) FOR [Amount]
GO
ALTER TABLE [dbo].[BillCollection] ADD  CONSTRAINT [DF__BillCollect__Rmk__33408412]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[BillCollection] ADD  CONSTRAINT [DF__BillColle__UserI__3528CC84]  DEFAULT ('') FOR [UserId]
GO
ALTER TABLE [dbo].[BillCollection] ADD  CONSTRAINT [DF__BillColle__Entry__361CF0BD]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[BillCollection] ADD  CONSTRAINT [DF__BillColle__PcNam__371114F6]  DEFAULT ('') FOR [PcName]
GO
ALTER TABLE [dbo].[BillCollection] ADD  CONSTRAINT [DF__BillColle__ComId__3805392F]  DEFAULT ('') FOR [ComId]
GO
ALTER TABLE [dbo].[BillCollection] ADD  DEFAULT ('') FOR [ColManId]
GO
ALTER TABLE [dbo].[Bonus] ADD  CONSTRAINT [DF_Bonus_EmpAutoNo]  DEFAULT (0) FOR [EmpAutoNo]
GO
ALTER TABLE [dbo].[Bonus] ADD  CONSTRAINT [DF_Bonus_ComID]  DEFAULT ('') FOR [ComID]
GO
ALTER TABLE [dbo].[Bonus] ADD  CONSTRAINT [DF_Bonus_ForMonth]  DEFAULT ('') FOR [ForMonth]
GO
ALTER TABLE [dbo].[Bonus] ADD  CONSTRAINT [DF_Bonus_ForYear]  DEFAULT ('') FOR [ForYear]
GO
ALTER TABLE [dbo].[Bonus] ADD  CONSTRAINT [DF_Bonus_Gross]  DEFAULT (0) FOR [Gross]
GO
ALTER TABLE [dbo].[Bonus] ADD  CONSTRAINT [DF_Bonus_Basic]  DEFAULT (0) FOR [Basic]
GO
ALTER TABLE [dbo].[Bonus] ADD  CONSTRAINT [DF_Bonus_BonusAmt]  DEFAULT (0) FOR [BonusAmt]
GO
ALTER TABLE [dbo].[Bonus] ADD  CONSTRAINT [DF_Bonus_Stmp]  DEFAULT (0) FOR [Stmp]
GO
ALTER TABLE [dbo].[Bonus] ADD  CONSTRAINT [DF_Bonus_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[Bonus] ADD  CONSTRAINT [DF_Bonus_SP]  DEFAULT (0) FOR [SP]
GO
ALTER TABLE [dbo].[Bonus] ADD  CONSTRAINT [DF_Bonus_SectionCode]  DEFAULT (0) FOR [SectionCode]
GO
ALTER TABLE [dbo].[Bonus] ADD  CONSTRAINT [DF_Bonus_DesignationCode]  DEFAULT (0) FOR [DesignationCode]
GO
ALTER TABLE [dbo].[Bonus] ADD  CONSTRAINT [DF_Bonus_FName]  DEFAULT ('') FOR [FName]
GO
ALTER TABLE [dbo].[BonusEid] ADD  CONSTRAINT [DF_BonusEid_stamp]  DEFAULT (0) FOR [stamp]
GO
ALTER TABLE [dbo].[BonusEid] ADD  CONSTRAINT [DF__bonuseid__status__3F6663D5]  DEFAULT (1) FOR [status]
GO
ALTER TABLE [dbo].[BonusEid] ADD  CONSTRAINT [DF__bonusEid__Consid__1BB31344]  DEFAULT (0) FOR [ConsiderDay]
GO
ALTER TABLE [dbo].[BonusEid] ADD  CONSTRAINT [DF__bonusEid__AdvPer__1CA7377D]  DEFAULT (0) FOR [AdvPercent]
GO
ALTER TABLE [dbo].[BonusEid] ADD  CONSTRAINT [DF__bonusEid__DOP__1D9B5BB6]  DEFAULT ('') FOR [DOP]
GO
ALTER TABLE [dbo].[Branch] ADD  CONSTRAINT [DF_Branch_CodeNo]  DEFAULT (0) FOR [ComID]
GO
ALTER TABLE [dbo].[Branch] ADD  CONSTRAINT [DF_Branch_Name]  DEFAULT ('') FOR [Name]
GO
ALTER TABLE [dbo].[Branch] ADD  CONSTRAINT [DF_Branch_Bname]  DEFAULT ('') FOR [Bname]
GO
ALTER TABLE [dbo].[Branch] ADD  CONSTRAINT [DF_Branch_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[Branch] ADD  CONSTRAINT [DF_Branch_Address]  DEFAULT ('') FOR [Address]
GO
ALTER TABLE [dbo].[Branch] ADD  CONSTRAINT [DF_Branch_Phone]  DEFAULT ('') FOR [Phone]
GO
ALTER TABLE [dbo].[Branch] ADD  CONSTRAINT [DF_Branch_Email]  DEFAULT ('') FOR [Email]
GO
ALTER TABLE [dbo].[Branch] ADD  CONSTRAINT [DF_Branch_Rpthead]  DEFAULT ('') FOR [Rpthead]
GO
ALTER TABLE [dbo].[Branch] ADD  CONSTRAINT [DF_Branch_PcName]  DEFAULT ('') FOR [PcName]
GO
ALTER TABLE [dbo].[Branch] ADD  CONSTRAINT [DF_Branch_UserCode]  DEFAULT ('') FOR [UserCode]
GO
ALTER TABLE [dbo].[Branch] ADD  CONSTRAINT [DF_Branch_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[Branch] ADD  CONSTRAINT [DF_Branch_SecCode]  DEFAULT ('PPT') FOR [SecCode]
GO
ALTER TABLE [dbo].[Branch] ADD  CONSTRAINT [DF_Branch_BranchName]  DEFAULT ('') FOR [BranchName]
GO
ALTER TABLE [dbo].[Branch] ADD  CONSTRAINT [DF_Branch_BranchCode]  DEFAULT ('') FOR [BranchCode]
GO
ALTER TABLE [dbo].[Branch] ADD  CONSTRAINT [DF_Branch_Mobile]  DEFAULT ('') FOR [Mobile]
GO
ALTER TABLE [dbo].[BS] ADD  CONSTRAINT [DF_BS_BStype]  DEFAULT ('') FOR [BStype]
GO
ALTER TABLE [dbo].[BS] ADD  CONSTRAINT [DF_BS_Debit]  DEFAULT (0) FOR [Debit]
GO
ALTER TABLE [dbo].[BS] ADD  CONSTRAINT [DF_BS_Credit]  DEFAULT (0) FOR [Credit]
GO
ALTER TABLE [dbo].[BS] ADD  CONSTRAINT [DF_BS_Remarks]  DEFAULT ('') FOR [Remarks]
GO
ALTER TABLE [dbo].[BS] ADD  CONSTRAINT [DF_BS_Grp]  DEFAULT ('') FOR [Grp]
GO
ALTER TABLE [dbo].[BS] ADD  CONSTRAINT [DF__bs__ComId__446BDB6B]  DEFAULT ('') FOR [ComId]
GO
ALTER TABLE [dbo].[BS] ADD  CONSTRAINT [DF__bs__PCName__455FFFA4]  DEFAULT ('') FOR [PCName]
GO
ALTER TABLE [dbo].[BTest] ADD  CONSTRAINT [DF_BTest_HeadName]  DEFAULT ('') FOR [HeadName]
GO
ALTER TABLE [dbo].[BTest] ADD  CONSTRAINT [DF_BTest_Debit]  DEFAULT (0) FOR [Debit]
GO
ALTER TABLE [dbo].[BTest] ADD  CONSTRAINT [DF_BTest_Credit]  DEFAULT (0) FOR [Credit]
GO
ALTER TABLE [dbo].[BTest] ADD  CONSTRAINT [DF_BTest_Grp]  DEFAULT ('') FOR [Grp]
GO
ALTER TABLE [dbo].[BTest] ADD  CONSTRAINT [DF__btest__ComId__428392F9]  DEFAULT ('') FOR [ComId]
GO
ALTER TABLE [dbo].[BTest] ADD  CONSTRAINT [DF__btest__PCName__4377B732]  DEFAULT ('') FOR [PCName]
GO
ALTER TABLE [dbo].[Class] ADD  CONSTRAINT [DF_Class_ClassID]  DEFAULT ('') FOR [ClassID]
GO
ALTER TABLE [dbo].[Class] ADD  CONSTRAINT [DF_Class_ClassName]  DEFAULT ('') FOR [ClassName]
GO
ALTER TABLE [dbo].[Class] ADD  CONSTRAINT [DF_Class_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[ClassInfo] ADD  CONSTRAINT [DF_ClassInfo_ClassCode]  DEFAULT (0) FOR [ClassCode]
GO
ALTER TABLE [dbo].[ClassInfo] ADD  CONSTRAINT [DF_ClassInfo_ClassName]  DEFAULT ('') FOR [ClassName]
GO
ALTER TABLE [dbo].[ClassInfo] ADD  CONSTRAINT [DF_ClassInfo_Duration]  DEFAULT (0) FOR [Duration]
GO
ALTER TABLE [dbo].[ClassInfo] ADD  CONSTRAINT [DF_ClassInfo_Fees]  DEFAULT (0) FOR [Fees]
GO
ALTER TABLE [dbo].[ClassInfo] ADD  CONSTRAINT [DF_ClassInfo_Curriculam]  DEFAULT ('') FOR [Curriculam]
GO
ALTER TABLE [dbo].[ClassInfo] ADD  CONSTRAINT [DF_ClassInfo_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[ClassInfo] ADD  CONSTRAINT [DF_ClassInfo_ComID]  DEFAULT ('1') FOR [ComID]
GO
ALTER TABLE [dbo].[ClassInfo] ADD  CONSTRAINT [DF__ClassInfo__SGrou__5B995986]  DEFAULT ('') FOR [SGroup]
GO
ALTER TABLE [dbo].[Committee] ADD  CONSTRAINT [DF_Committee_ForYear]  DEFAULT ('') FOR [ForYear]
GO
ALTER TABLE [dbo].[Committee] ADD  CONSTRAINT [DF_Committee_TOCommittee]  DEFAULT ('') FOR [TOCommittee]
GO
ALTER TABLE [dbo].[Committee] ADD  CONSTRAINT [DF_Committee_Serial]  DEFAULT (0) FOR [SLNO]
GO
ALTER TABLE [dbo].[Committee] ADD  CONSTRAINT [DF_Committee_Deg]  DEFAULT ('') FOR [Deg]
GO
ALTER TABLE [dbo].[Committee] ADD  CONSTRAINT [DF_Committee_Name]  DEFAULT ('') FOR [Name]
GO
ALTER TABLE [dbo].[Committee] ADD  CONSTRAINT [DF_Committee_Remarks]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[Committee] ADD  CONSTRAINT [DF_Committee_ComID]  DEFAULT ('1') FOR [ComID]
GO
ALTER TABLE [dbo].[Complaint] ADD  CONSTRAINT [DF__Complaint__CId__39ED81A1]  DEFAULT ('') FOR [CId]
GO
ALTER TABLE [dbo].[Complaint] ADD  CONSTRAINT [DF__Complaint__CName__3AE1A5DA]  DEFAULT ('') FOR [CName]
GO
ALTER TABLE [dbo].[Complaint] ADD  CONSTRAINT [DF__Complaint__Type__3BD5CA13]  DEFAULT ('') FOR [Type]
GO
ALTER TABLE [dbo].[Complaint] ADD  CONSTRAINT [DF__Complaint__Detai__3CC9EE4C]  DEFAULT ('') FOR [Detail]
GO
ALTER TABLE [dbo].[Complaint] ADD  CONSTRAINT [DF__Complaint__Actn__3DBE1285]  DEFAULT ('') FOR [Actn]
GO
ALTER TABLE [dbo].[Complaint] ADD  CONSTRAINT [DF__Complaint__EmpNa__3EB236BE]  DEFAULT ('') FOR [EmpName]
GO
ALTER TABLE [dbo].[Complaint] ADD  CONSTRAINT [DF__Complaint__UserI__409A7F30]  DEFAULT ('') FOR [UserId]
GO
ALTER TABLE [dbo].[Complaint] ADD  CONSTRAINT [DF__Complaint__PcNam__418EA369]  DEFAULT ('') FOR [PcName]
GO
ALTER TABLE [dbo].[Complaint] ADD  CONSTRAINT [DF__Complaint__ComId__4282C7A2]  DEFAULT ('') FOR [ComId]
GO
ALTER TABLE [dbo].[Currency] ADD  CONSTRAINT [DF_Currency_CurName]  DEFAULT ('') FOR [CurName]
GO
ALTER TABLE [dbo].[Currency] ADD  CONSTRAINT [DF_Currency_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[Currency] ADD  CONSTRAINT [DF_Currency_ComID]  DEFAULT ('') FOR [ComID]
GO
ALTER TABLE [dbo].[Currency] ADD  CONSTRAINT [DF_Currency_CurRateTk]  DEFAULT (0) FOR [CurRateTk]
GO
ALTER TABLE [dbo].[Currency] ADD  CONSTRAINT [DF__currency__SLNo__45943E77]  DEFAULT (0) FOR [SLNo]
GO
ALTER TABLE [dbo].[Currency] ADD  CONSTRAINT [DF__currency__CurRat__468862B0]  DEFAULT (0) FOR [CurRateUSD]
GO
ALTER TABLE [dbo].[Curriculam] ADD  CONSTRAINT [DF_Curriculam_ClassID]  DEFAULT (0) FOR [ClassID]
GO
ALTER TABLE [dbo].[Curriculam] ADD  CONSTRAINT [DF_Curriculam_SubID]  DEFAULT (0) FOR [SubID]
GO
ALTER TABLE [dbo].[Curriculam] ADD  CONSTRAINT [DF_Curriculam_ComID]  DEFAULT ('') FOR [ComID]
GO
ALTER TABLE [dbo].[DAForFastPull] ADD  CONSTRAINT [DF_DAForFastPull_EmpId]  DEFAULT ('') FOR [EmpId]
GO
ALTER TABLE [dbo].[DAForFastPull] ADD  CONSTRAINT [DF_DAForFastPull_EmpAutoNo]  DEFAULT (0) FOR [EmpAutoNo]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_EmpAutoNo]  DEFAULT (0) FOR [EmpAutoNo]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_ComID]  DEFAULT ('1') FOR [ComID]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_OT]  DEFAULT (0) FOR [OT]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_OtB]  DEFAULT (0) FOR [OtB]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_Status]  DEFAULT ('') FOR [Status]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_LateRmk]  DEFAULT ('') FOR [LateRmk]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_HolidayRmk]  DEFAULT ('') FOR [HolidayRmk]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_LeaveRmk]  DEFAULT ('') FOR [LeaveRmk]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_HolidayWork]  DEFAULT (0) FOR [HolidayWork]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_REM]  DEFAULT ('') FOR [REM]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_OtHr]  DEFAULT (0) FOR [OtHr]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_OtMnt]  DEFAULT (0) FOR [OtMnt]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_OtHrB]  DEFAULT (0) FOR [OtHrB]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_OtMntB]  DEFAULT (0) FOR [OtMntB]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_PresentQty]  DEFAULT (0) FOR [PresentQty]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_AbsentQty]  DEFAULT (0) FOR [AbsentQty]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_LeaveQty]  DEFAULT (0) FOR [LeaveQty]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_LATEQTY]  DEFAULT (0) FOR [LATEQTY]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_HolidayQty]  DEFAULT (0) FOR [HolidayQty]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_HDP]  DEFAULT (0) FOR [HDP]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_GroupID]  DEFAULT ('') FOR [GroupID]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_Device]  DEFAULT ('') FOR [Device]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_WHr]  DEFAULT (0) FOR [WHr]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_IsManualType]  DEFAULT ('') FOR [IsManualType]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_TotalEmp]  DEFAULT (0) FOR [TotalEmp]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_Male]  DEFAULT (0) FOR [Male]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_Female]  DEFAULT (0) FOR [Female]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_MaleP]  DEFAULT (0) FOR [MaleP]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_FemaleP]  DEFAULT (0) FOR [FemaleP]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_MaleA]  DEFAULT (0) FOR [MaleA]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_FemaleA]  DEFAULT (0) FOR [FemaleA]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_NightOT]  DEFAULT (0) FOR [NightOT]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_MaxOT]  DEFAULT (0) FOR [MaxOT]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_SingleEntry]  DEFAULT (0) FOR [SingleEntry]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_GD]  DEFAULT (0) FOR [GD]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_ExtraOTHr]  DEFAULT (0) FOR [ExtraOTHr]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_LunchDayMinus]  DEFAULT (0) FOR [LunchDayMinus]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_UserName]  DEFAULT ('') FOR [UserName]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_CARDNO]  DEFAULT ('') FOR [CARDNO]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_REMARKS]  DEFAULT ('') FOR [REMARKS]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_LunchDay]  DEFAULT (0) FOR [LunchDay]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_BusDay]  DEFAULT (0) FOR [BusDay]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_Leave]  DEFAULT ('') FOR [Leave]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_Late]  DEFAULT ('') FOR [Late]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_HoliDay]  DEFAULT ('') FOR [HoliDay]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_hwqty]  DEFAULT (0) FOR [hwqty]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_statusb]  DEFAULT ('') FOR [statusb]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_CL]  DEFAULT (0) FOR [CL]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_EL]  DEFAULT (0) FOR [EL]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_ML]  DEFAULT (0) FOR [ML]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_SL]  DEFAULT (0) FOR [SL]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_WHol]  DEFAULT (0) FOR [WHol]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_FHol]  DEFAULT (0) FOR [FHol]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_LateMnt]  DEFAULT (0) FOR [LateMnt]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF_DailyAttn_ManualRmk]  DEFAULT ('') FOR [ManualRmk]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF__dailyattn__Early__4E28EAEB]  DEFAULT (0) FOR [EarlyOut]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF__DailyAttn__GovHo__7EB7DF04]  DEFAULT (0) FOR [GovHoliDay]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF__DailyAttn__Trans__074D2505]  DEFAULT (0) FOR [Transport]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF__DailyAttn__Lunch__0841493E]  DEFAULT (0) FOR [Lunch]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF__dailyattn__PQty__522F1F86]  DEFAULT (0) FOR [PQty]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF__dailyattn__AQty__532343BF]  DEFAULT (0) FOR [AQty]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF__dailyattn__SQty__541767F8]  DEFAULT (0) FOR [SQty]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF__DailyAttn__NWDay__57E7F8DC]  DEFAULT (0) FOR [NWDay]
GO
ALTER TABLE [dbo].[DailyAttn] ADD  CONSTRAINT [DF__dailyattn__Early__7C910454]  DEFAULT (0) FOR [EarlyOutQTy]
GO
ALTER TABLE [dbo].[DailyCash] ADD  CONSTRAINT [DF__DailyCash__Sl__7D6E8346]  DEFAULT ('') FOR [Sl]
GO
ALTER TABLE [dbo].[DailyCash] ADD  CONSTRAINT [DF__DailyCash__Type__7E62A77F]  DEFAULT ('') FOR [Type]
GO
ALTER TABLE [dbo].[DailyCash] ADD  CONSTRAINT [DF__DailyCash__Des__7F56CBB8]  DEFAULT ('') FOR [Des]
GO
ALTER TABLE [dbo].[DailyCash] ADD  CONSTRAINT [DF__DailyCash__Amoun__004AEFF1]  DEFAULT (0) FOR [Amount]
GO
ALTER TABLE [dbo].[DailyCash] ADD  CONSTRAINT [DF__DailyCash__Entry__013F142A]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[DailyCash] ADD  CONSTRAINT [DF__DailyCash__UserC__02333863]  DEFAULT ('') FOR [UserCode]
GO
ALTER TABLE [dbo].[DailyCash] ADD  CONSTRAINT [DF__DailyCash__PcNam__03275C9C]  DEFAULT ('') FOR [PcName]
GO
ALTER TABLE [dbo].[DailyCash] ADD  CONSTRAINT [DF__DailyCash__ComId__041B80D5]  DEFAULT ('') FOR [ComId]
GO
ALTER TABLE [dbo].[DailyCash] ADD  CONSTRAINT [DF__DailyCash__AutoN__050FA50E]  DEFAULT ('') FOR [AutoNo]
GO
ALTER TABLE [dbo].[DailyCashMstr] ADD  CONSTRAINT [DF__DailyCashMst__Sl__73E5190C]  DEFAULT ('') FOR [Sl]
GO
ALTER TABLE [dbo].[DailyCashMstr] ADD  CONSTRAINT [DF__DailyCash__TotCo__74D93D45]  DEFAULT (0) FOR [TotCol]
GO
ALTER TABLE [dbo].[DailyCashMstr] ADD  CONSTRAINT [DF__DailyCash__TotPa__75CD617E]  DEFAULT (0) FOR [TotPay]
GO
ALTER TABLE [dbo].[DailyCashMstr] ADD  CONSTRAINT [DF__DailyCash__CashB__76C185B7]  DEFAULT (0) FOR [CashBal]
GO
ALTER TABLE [dbo].[DailyCashMstr] ADD  CONSTRAINT [DF__DailyCash__Entry__77B5A9F0]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[DailyCashMstr] ADD  CONSTRAINT [DF__DailyCash__UserC__78A9CE29]  DEFAULT ('') FOR [UserCode]
GO
ALTER TABLE [dbo].[DailyCashMstr] ADD  CONSTRAINT [DF__DailyCash__PcNam__799DF262]  DEFAULT ('') FOR [PcName]
GO
ALTER TABLE [dbo].[DailyCashMstr] ADD  CONSTRAINT [DF__DailyCash__ComId__7A92169B]  DEFAULT ('') FOR [ComId]
GO
ALTER TABLE [dbo].[DailyCashMstr] ADD  CONSTRAINT [DF__DailyCash__AutoN__7B863AD4]  DEFAULT ('') FOR [AutoNo]
GO
ALTER TABLE [dbo].[Damages] ADD  CONSTRAINT [DF_Damages_DamagesCode]  DEFAULT ('') FOR [DamCode]
GO
ALTER TABLE [dbo].[Damages] ADD  CONSTRAINT [DF_Damages_Item]  DEFAULT ('') FOR [ItemCode]
GO
ALTER TABLE [dbo].[Damages] ADD  CONSTRAINT [DF_Damages_Rkm]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[Damages] ADD  CONSTRAINT [DF_Damages_Qty]  DEFAULT (0) FOR [Qty]
GO
ALTER TABLE [dbo].[Damages] ADD  CONSTRAINT [DF_Damages_ComId]  DEFAULT ('') FOR [ComId]
GO
ALTER TABLE [dbo].[Damages] ADD  CONSTRAINT [DF_Damages_ItemAutoNo]  DEFAULT (0) FOR [ItemAutoNo]
GO
ALTER TABLE [dbo].[Damages] ADD  CONSTRAINT [DF_Damages_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[Damages] ADD  CONSTRAINT [DF_Damages_PCName]  DEFAULT ('') FOR [PCName]
GO
ALTER TABLE [dbo].[Damages] ADD  CONSTRAINT [DF_Damages_AutoNoFromMstrTbl]  DEFAULT (0) FOR [AutoNoFromMstrTbl]
GO
ALTER TABLE [dbo].[DamagesMstr] ADD  CONSTRAINT [DF_DamagesMstr_PCName]  DEFAULT ('') FOR [PCName]
GO
ALTER TABLE [dbo].[DamagesMstr] ADD  CONSTRAINT [DF_DamagesMstr_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[DamagesMstr] ADD  CONSTRAINT [DF_DamagesMstr_ComId]  DEFAULT ('') FOR [ComId]
GO
ALTER TABLE [dbo].[DamagesMstr] ADD  CONSTRAINT [DF_DamagesMstr_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[DamagesMstr] ADD  CONSTRAINT [DF_DamagesMstr_Type]  DEFAULT ('') FOR [Type]
GO
ALTER TABLE [dbo].[DAttn] ADD  CONSTRAINT [DF_DAttn_DeviceNo]  DEFAULT ('') FOR [DeviceNo]
GO
ALTER TABLE [dbo].[DAttn] ADD  CONSTRAINT [DF_DAttn_OTHr]  DEFAULT (0) FOR [OTHr]
GO
ALTER TABLE [dbo].[DAttn] ADD  CONSTRAINT [DF_DAttn_OTMnt]  DEFAULT (0) FOR [OTMnt]
GO
ALTER TABLE [dbo].[DAttn] ADD  CONSTRAINT [DF_DAttn_OT]  DEFAULT (0) FOR [OT]
GO
ALTER TABLE [dbo].[DAttn] ADD  CONSTRAINT [DF_DAttn_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[DAttn] ADD  CONSTRAINT [DF_DAttn_CardNo]  DEFAULT ('') FOR [CardNo]
GO
ALTER TABLE [dbo].[Department] ADD  CONSTRAINT [DF_Department_Name]  DEFAULT ('') FOR [Name]
GO
ALTER TABLE [dbo].[Department] ADD  CONSTRAINT [DF_Department_Bname]  DEFAULT ('') FOR [Bname]
GO
ALTER TABLE [dbo].[Department] ADD  CONSTRAINT [DF_Department_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[Department] ADD  CONSTRAINT [DF_Department_ComID]  DEFAULT ('1') FOR [ComID]
GO
ALTER TABLE [dbo].[Department] ADD  CONSTRAINT [DF_Department_PcName]  DEFAULT ('') FOR [PcName]
GO
ALTER TABLE [dbo].[Department] ADD  CONSTRAINT [DF_Department_UserCode]  DEFAULT (0) FOR [UserCode]
GO
ALTER TABLE [dbo].[Department] ADD  CONSTRAINT [DF_Department_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[Department] ADD  CONSTRAINT [DF_Department_ShortName]  DEFAULT ('') FOR [ShortName]
GO
ALTER TABLE [dbo].[Designation] ADD  CONSTRAINT [DF_Designation_CodeNo]  DEFAULT ('') FOR [CodeNo]
GO
ALTER TABLE [dbo].[Designation] ADD  CONSTRAINT [DF_Designation_Name]  DEFAULT ('') FOR [Name]
GO
ALTER TABLE [dbo].[Designation] ADD  CONSTRAINT [DF_Designation_bangDesig]  DEFAULT ('') FOR [bangDesig]
GO
ALTER TABLE [dbo].[Designation] ADD  CONSTRAINT [DF_Designation_gradeid]  DEFAULT ('') FOR [gradeid]
GO
ALTER TABLE [dbo].[Designation] ADD  CONSTRAINT [DF_Designation_LunchMoney]  DEFAULT (0) FOR [LunchMoney]
GO
ALTER TABLE [dbo].[Designation] ADD  CONSTRAINT [DF_Designation_FBonus]  DEFAULT (0) FOR [FBonus]
GO
ALTER TABLE [dbo].[Designation] ADD  CONSTRAINT [DF_Designation_Bname]  DEFAULT ('') FOR [Bname]
GO
ALTER TABLE [dbo].[Designation] ADD  CONSTRAINT [DF_Designation_attnBonus]  DEFAULT (0) FOR [attnBonus]
GO
ALTER TABLE [dbo].[Designation] ADD  CONSTRAINT [DF_Designation_OT]  DEFAULT (0) FOR [OT]
GO
ALTER TABLE [dbo].[Designation] ADD  CONSTRAINT [DF_Designation_OthersAdd]  DEFAULT (0) FOR [OthersAdd]
GO
ALTER TABLE [dbo].[Designation] ADD  CONSTRAINT [DF_Designation_DesigGroup]  DEFAULT ('') FOR [DesigGroup]
GO
ALTER TABLE [dbo].[Designation] ADD  CONSTRAINT [DF_Designation_SalaryGroup]  DEFAULT ('') FOR [SalaryGroup]
GO
ALTER TABLE [dbo].[Designation] ADD  CONSTRAINT [DF_Designation_ComId]  DEFAULT ('') FOR [ComId]
GO
ALTER TABLE [dbo].[Designation] ADD  CONSTRAINT [DF_Designation_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[Designation] ADD  CONSTRAINT [DF_Designation_PcName]  DEFAULT ('') FOR [PcName]
GO
ALTER TABLE [dbo].[Designation] ADD  CONSTRAINT [DF_Designation_UserCode]  DEFAULT ('') FOR [UserCode]
GO
ALTER TABLE [dbo].[Designation] ADD  CONSTRAINT [DF__Designati__Trans__0D05FE5B]  DEFAULT (0) FOR [Transport]
GO
ALTER TABLE [dbo].[Designation] ADD  CONSTRAINT [DF__Designati__Lunch__0DFA2294]  DEFAULT (0) FOR [Lunch]
GO
ALTER TABLE [dbo].[DeviceData] ADD  CONSTRAINT [DF_DeviceData_EMPId]  DEFAULT ('') FOR [EMPId]
GO
ALTER TABLE [dbo].[DeviceData] ADD  CONSTRAINT [DF_DeviceData_CardNo]  DEFAULT ('') FOR [CardNo]
GO
ALTER TABLE [dbo].[DeviceData] ADD  CONSTRAINT [DF_DeviceData_SwipeDateStr]  DEFAULT ('') FOR [SwipeDateStr]
GO
ALTER TABLE [dbo].[DeviceData] ADD  CONSTRAINT [DF_DeviceData_SwipeTimeStr]  DEFAULT ('') FOR [SwipeTimeStr]
GO
ALTER TABLE [dbo].[DeviceData] ADD  CONSTRAINT [DF_DeviceData_DeviceNo]  DEFAULT ('') FOR [DeviceNo]
GO
ALTER TABLE [dbo].[DeviceData] ADD  CONSTRAINT [DF_DeviceData_ComId]  DEFAULT ('1') FOR [ComId]
GO
ALTER TABLE [dbo].[DeviceData] ADD  CONSTRAINT [DF__deviceDat__devic__3FDACB94]  DEFAULT ('') FOR [deviceType]
GO
ALTER TABLE [dbo].[DeviceData] ADD  CONSTRAINT [DF__deviceDat__EmpAu__42B7383F]  DEFAULT (0) FOR [EmpAutoNo]
GO
ALTER TABLE [dbo].[DeviceData] ADD  CONSTRAINT [DF__deviceDat__RawDa__5011335D]  DEFAULT ('') FOR [RawData]
GO
ALTER TABLE [dbo].[DeviceData] ADD  CONSTRAINT [DF_DeviceData_InOutType]  DEFAULT ('') FOR [InOutType]
GO
ALTER TABLE [dbo].[DManualAttn] ADD  CONSTRAINT [DF_DManualAttn_Empid]  DEFAULT ('') FOR [Empid]
GO
ALTER TABLE [dbo].[DManualAttn] ADD  CONSTRAINT [DF_DManualAttn_IsmanualType]  DEFAULT ('') FOR [IsmanualType]
GO
ALTER TABLE [dbo].[DManualAttn] ADD  CONSTRAINT [DF_DManualAttn_Entrytime]  DEFAULT (getdate()) FOR [Entrytime]
GO
ALTER TABLE [dbo].[DManualAttn] ADD  CONSTRAINT [DF_DManualAttn_EmpAutoNo]  DEFAULT (0) FOR [EmpAutoNo]
GO
ALTER TABLE [dbo].[DManualAttn] ADD  CONSTRAINT [DF__dManualAtt__Note__4D34C6B2]  DEFAULT ('') FOR [Note]
GO
ALTER TABLE [dbo].[DManualAttn] ADD  CONSTRAINT [DF__dManualAt__REMAR__00619538]  DEFAULT ('') FOR [REMARKS]
GO
ALTER TABLE [dbo].[DManualAttn] ADD  CONSTRAINT [DF__dManualAt__UserN__0155B971]  DEFAULT ('') FOR [UserName]
GO
ALTER TABLE [dbo].[Document] ADD  CONSTRAINT [DF_Document_DocNo]  DEFAULT (0) FOR [DocNo]
GO
ALTER TABLE [dbo].[Document] ADD  CONSTRAINT [DF_Document_DocType]  DEFAULT ('') FOR [DocType]
GO
ALTER TABLE [dbo].[Document] ADD  CONSTRAINT [DF_Document_ComId]  DEFAULT ('1') FOR [ComId]
GO
ALTER TABLE [dbo].[Document] ADD  CONSTRAINT [DF_Document_UserId]  DEFAULT ('') FOR [UserId]
GO
ALTER TABLE [dbo].[Document] ADD  CONSTRAINT [DF_Document_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[Document] ADD  CONSTRAINT [DF_Document_PCName]  DEFAULT ('') FOR [PCName]
GO
ALTER TABLE [dbo].[Document] ADD  CONSTRAINT [DF_Document_filename]  DEFAULT ('') FOR [filename]
GO
ALTER TABLE [dbo].[Document] ADD  CONSTRAINT [DF_Document_PartyName]  DEFAULT ('') FOR [PartyName]
GO
ALTER TABLE [dbo].[Document] ADD  CONSTRAINT [DF_Document_FileType]  DEFAULT ('') FOR [FileType]
GO
ALTER TABLE [dbo].[Document] ADD  CONSTRAINT [DF_Document_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[Document] ADD  CONSTRAINT [DF_Document_DocName]  DEFAULT ('') FOR [DocName]
GO
ALTER TABLE [dbo].[Document] ADD  CONSTRAINT [DF_Document_StoreCode]  DEFAULT (0) FOR [StoreCode]
GO
ALTER TABLE [dbo].[Document] ADD  CONSTRAINT [DF_Document_Unitcode]  DEFAULT (0) FOR [Unitcode]
GO
ALTER TABLE [dbo].[DonnerList] ADD  CONSTRAINT [DF_DonnerList_SLNo]  DEFAULT (0) FOR [SLNo]
GO
ALTER TABLE [dbo].[DonnerList] ADD  CONSTRAINT [DF_DonnerList_Donner]  DEFAULT ('') FOR [DonnerName]
GO
ALTER TABLE [dbo].[DonnerList] ADD  CONSTRAINT [DF_DonnerList_Amount]  DEFAULT (0) FOR [Amount]
GO
ALTER TABLE [dbo].[DonnerList] ADD  CONSTRAINT [DF_DonnerList_Remarks]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[DonnerList] ADD  CONSTRAINT [DF_DonnerList_ComId]  DEFAULT ('1') FOR [ComId]
GO
ALTER TABLE [dbo].[Education] ADD  CONSTRAINT [DF_Education_EmpAutoNo]  DEFAULT (1) FOR [EmpAutoNo]
GO
ALTER TABLE [dbo].[Education] ADD  CONSTRAINT [DF_Education_EmpId]  DEFAULT ('') FOR [EmpId]
GO
ALTER TABLE [dbo].[Education] ADD  CONSTRAINT [DF_Education_EduID]  DEFAULT ('') FOR [EduID]
GO
ALTER TABLE [dbo].[Education] ADD  CONSTRAINT [DF_Education_Edegree]  DEFAULT ('') FOR [EDegree]
GO
ALTER TABLE [dbo].[Education] ADD  CONSTRAINT [DF_Education_Institution]  DEFAULT ('') FOR [Institution]
GO
ALTER TABLE [dbo].[Education] ADD  CONSTRAINT [DF_Education_Syear]  DEFAULT ('') FOR [SYear]
GO
ALTER TABLE [dbo].[Education] ADD  CONSTRAINT [DF_Education_Result]  DEFAULT ('') FOR [Result]
GO
ALTER TABLE [dbo].[Education] ADD  CONSTRAINT [DF_Education_Description]  DEFAULT ('') FOR [Description]
GO
ALTER TABLE [dbo].[Education] ADD  CONSTRAINT [DF_Education_comid]  DEFAULT ('') FOR [ComID]
GO
ALTER TABLE [dbo].[Education] ADD  CONSTRAINT [DF_Education_PcName]  DEFAULT ('') FOR [PcName]
GO
ALTER TABLE [dbo].[Education] ADD  CONSTRAINT [DF_Education_UserCode]  DEFAULT (0) FOR [UserCode]
GO
ALTER TABLE [dbo].[Education] ADD  CONSTRAINT [DF_Education_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[ELCalculation] ADD  CONSTRAINT [DF_ELCalculation_EmpAutoNO]  DEFAULT (0) FOR [EmpAutoNO]
GO
ALTER TABLE [dbo].[ELCalculation] ADD  CONSTRAINT [DF_ELCalculation_EmpId]  DEFAULT ('') FOR [EmpId]
GO
ALTER TABLE [dbo].[ELCalculation] ADD  CONSTRAINT [DF_ELCalculation_forYear]  DEFAULT ('') FOR [ForYear]
GO
ALTER TABLE [dbo].[ELCalculation] ADD  CONSTRAINT [DF_ELCalculation_TotWorkDay]  DEFAULT (0) FOR [TotWorkDay]
GO
ALTER TABLE [dbo].[ELCalculation] ADD  CONSTRAINT [DF_ELCalculation_ELDay]  DEFAULT (0) FOR [ELDay]
GO
ALTER TABLE [dbo].[ELCalculation] ADD  CONSTRAINT [DF_ELCalculation_ELAmount]  DEFAULT (0) FOR [Amount]
GO
ALTER TABLE [dbo].[ELCalculation] ADD  CONSTRAINT [DF_ELCalculation_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[ELCalculation] ADD  CONSTRAINT [DF_ELCalculation_UserCode]  DEFAULT (0) FOR [UserCode]
GO
ALTER TABLE [dbo].[ELCalculation] ADD  CONSTRAINT [DF_ELCalculation_PcName]  DEFAULT ('') FOR [PcName]
GO
ALTER TABLE [dbo].[ELCalculation] ADD  CONSTRAINT [DF_ELCalculation_ComID_1]  DEFAULT ('') FOR [ComID]
GO
ALTER TABLE [dbo].[ELCalculation] ADD  CONSTRAINT [DF_ELCalculation_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[ELCalculation] ADD  CONSTRAINT [DF__elCalcula__Gross__72B2C629]  DEFAULT (0) FOR [Gross]
GO
ALTER TABLE [dbo].[ELCalculation] ADD  CONSTRAINT [DF__elCalcula__Basic__73A6EA62]  DEFAULT (0) FOR [Basic]
GO
ALTER TABLE [dbo].[ELCalculationORG] ADD  CONSTRAINT [DF__elcalcula__ELBal__039C5DE8]  DEFAULT (0) FOR [ELBal]
GO
ALTER TABLE [dbo].[ELCalculationORG] ADD  CONSTRAINT [DF__elcalcula__gross__04908221]  DEFAULT (0) FOR [gross]
GO
ALTER TABLE [dbo].[ELCalculationORG] ADD  CONSTRAINT [DF__elcalcula__ELAvl__6A669BCA]  DEFAULT (0) FOR [ELAvl]
GO
ALTER TABLE [dbo].[ELCalculationORG] ADD  CONSTRAINT [DF__ELCalculat__ElYr__45FE52CB]  DEFAULT ('') FOR [ElYr]
GO
ALTER TABLE [dbo].[ELCalculationORG] ADD  CONSTRAINT [DF__ELCalcula__ElMon__46F27704]  DEFAULT (0) FOR [ElMoney]
GO
ALTER TABLE [dbo].[EmpID] ADD  CONSTRAINT [DF_TemID_Empid]  DEFAULT (0) FOR [SlNo]
GO
ALTER TABLE [dbo].[EmpID] ADD  CONSTRAINT [DF_TemID_Empid1]  DEFAULT ('') FOR [Emp1]
GO
ALTER TABLE [dbo].[EmpID] ADD  CONSTRAINT [DF_TemID_Empid2]  DEFAULT ('') FOR [Emp2]
GO
ALTER TABLE [dbo].[EmpID] ADD  CONSTRAINT [DF_TemID_Empid3]  DEFAULT ('') FOR [Emp3]
GO
ALTER TABLE [dbo].[EmpID] ADD  CONSTRAINT [DF_TemID_Empid4]  DEFAULT ('') FOR [Emp4]
GO
ALTER TABLE [dbo].[EmpID] ADD  CONSTRAINT [DF__temid__slno__69678A99]  DEFAULT ('') FOR [Emp5]
GO
ALTER TABLE [dbo].[EmpID] ADD  CONSTRAINT [DF_EmpID_EmpAutoNo1]  DEFAULT (0) FOR [EmpAutoNo1]
GO
ALTER TABLE [dbo].[EmpID] ADD  CONSTRAINT [DF_EmpID_EmpAutoNo2]  DEFAULT (0) FOR [EmpAutoNo2]
GO
ALTER TABLE [dbo].[EmpID] ADD  CONSTRAINT [DF_EmpID_EmpAutoNo3]  DEFAULT (0) FOR [EmpAutoNo3]
GO
ALTER TABLE [dbo].[EmpID] ADD  CONSTRAINT [DF_EmpID_EmpAutoNo4]  DEFAULT (0) FOR [EmpAutoNo4]
GO
ALTER TABLE [dbo].[EmpID] ADD  CONSTRAINT [DF_EmpID_EmpAutoNo5]  DEFAULT (0) FOR [EmpAutoNo5]
GO
ALTER TABLE [dbo].[EmpInfo] ADD  CONSTRAINT [DF__EmpInfo__EmpId__7AC720C5]  DEFAULT ('') FOR [EmpId]
GO
ALTER TABLE [dbo].[EmpInfo] ADD  CONSTRAINT [DF__EmpInfo__EmpName__7BBB44FE]  DEFAULT ('') FOR [EmpName]
GO
ALTER TABLE [dbo].[EmpInfo] ADD  CONSTRAINT [DF__EmpInfo__FName__7CAF6937]  DEFAULT ('') FOR [FName]
GO
ALTER TABLE [dbo].[EmpInfo] ADD  CONSTRAINT [DF__EmpInfo__MName__7DA38D70]  DEFAULT ('') FOR [MName]
GO
ALTER TABLE [dbo].[EmpInfo] ADD  CONSTRAINT [DF__EmpInfo__Desig__7E97B1A9]  DEFAULT ('') FOR [Desig]
GO
ALTER TABLE [dbo].[EmpInfo] ADD  CONSTRAINT [DF__EmpInfo__Sex__7F8BD5E2]  DEFAULT ('') FOR [Sex]
GO
ALTER TABLE [dbo].[EmpInfo] ADD  CONSTRAINT [DF__EmpInfo__Salary__007FFA1B]  DEFAULT (0) FOR [Salary]
GO
ALTER TABLE [dbo].[EmpInfo] ADD  CONSTRAINT [DF__EmpInfo__NID__01741E54]  DEFAULT ('') FOR [NID]
GO
ALTER TABLE [dbo].[EmpInfo] ADD  CONSTRAINT [DF__EmpInfo__Rmk__0268428D]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[EmpInfo] ADD  CONSTRAINT [DF__EmpInfo__ComId__035C66C6]  DEFAULT ('') FOR [ComId]
GO
ALTER TABLE [dbo].[EmpInfo] ADD  CONSTRAINT [DF__EmpInfo__UserId__04508AFF]  DEFAULT ('') FOR [UserId]
GO
ALTER TABLE [dbo].[EmpInfo] ADD  CONSTRAINT [DF__EmpInfo__PcName__0544AF38]  DEFAULT ('') FOR [PcName]
GO
ALTER TABLE [dbo].[EmpInfo] ADD  CONSTRAINT [DF__EmpInfo__EntryTi__0638D371]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[EmpInfo] ADD  DEFAULT ('') FOR [BName]
GO
ALTER TABLE [dbo].[EmpInfo] ADD  DEFAULT (0) FOR [SalaryInt]
GO
ALTER TABLE [dbo].[EmpInfo] ADD  DEFAULT (0) FOR [SalaryDis]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_EmpId_1]  DEFAULT ('') FOR [EmpId]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_Name]  DEFAULT ('') FOR [Name]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_FatherName]  DEFAULT ('') FOR [FatherName]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_MotherName]  DEFAULT ('') FOR [MotherName]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_Sex]  DEFAULT ('') FOR [Sex]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_Age]  DEFAULT ('') FOR [Age]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_MStatus]  DEFAULT ('') FOR [MStatus]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_SpouseName_1]  DEFAULT ('') FOR [SpouseName]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_PeAddress]  DEFAULT ('') FOR [PeAddress]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_PrAddress]  DEFAULT ('') FOR [PrAddress]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_Phone]  DEFAULT ('') FOR [Phone]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_Blood]  DEFAULT ('') FOR [Blood]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_Relegion]  DEFAULT ('') FOR [Relegion]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_NID]  DEFAULT ('') FOR [NID]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_Reference1]  DEFAULT ('') FOR [Reference1]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_Reference2]  DEFAULT ('') FOR [Reference2]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_Type]  DEFAULT ('') FOR [Type]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_DesignationCode_1]  DEFAULT (0) FOR [DesignationCode]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_SectionCode_1]  DEFAULT (0) FOR [SectionCode]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_DepartmentCode_1]  DEFAULT (0) FOR [DepartmentCode]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_GradeCode_1]  DEFAULT (0) FOR [GradeCode]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_Shift]  DEFAULT ('') FOR [Shift]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_CardNo]  DEFAULT ('') FOR [CardNo]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_Basic]  DEFAULT (0) FOR [Basic]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_Gross]  DEFAULT (0) FOR [Gross]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_AccountNo_1]  DEFAULT ('') FOR [AccountNo]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_HRent]  DEFAULT (0) FOR [HRent]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_Medical]  DEFAULT (0) FOR [Medical]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_Active]  DEFAULT (0) FOR [Active]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_OverTime]  DEFAULT (0) FOR [OverTime]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_AttendenceBonus]  DEFAULT (0) FOR [AttendenceBonus]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_Transport]  DEFAULT (0) FOR [Transport]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_MobileAllow]  DEFAULT (0) FOR [MobileAllow]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_Intensive_1]  DEFAULT (0) FOR [Intensive]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_PF]  DEFAULT (0) FOR [PF]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_IncomeTax]  DEFAULT (0) FOR [IncomeTax]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_PcName_1]  DEFAULT ('') FOR [PcName]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_UserCode]  DEFAULT ('') FOR [UserCode]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF__Employee__GrossU__5EE9FC26]  DEFAULT (0) FOR [GrossUsd]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF__Employee__bank__0DA4EB0F]  DEFAULT (0) FOR [bank]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF__employee__SLNo__496435CE]  DEFAULT (0) FOR [SLNo]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF__employee__BName__6E81773B]  DEFAULT ('') FOR [BName]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF__employee__Resign__6F759B74]  DEFAULT ('') FOR [ResignType]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF__employee__Lefty__7069BFAD]  DEFAULT (0) FOR [Lefty]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF__employee__SalTyp__2744C181]  DEFAULT ('') FOR [SalType]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF__employee__BirthI__47B19113]  DEFAULT ('') FOR [BirthID]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF__employee__Allnc__4999D985]  DEFAULT (0) FOR [Allnc]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF__employee__confMo__4A8DFDBE]  DEFAULT (0) FOR [confMonth]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF__employee__Gage__4B8221F7]  DEFAULT ('') FOR [Gage]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF__employee__Status__73FBBE53]  DEFAULT (0) FOR [Status]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF__employee__AttnBo__7AA8BBE2]  DEFAULT (0) FOR [AttnBonusAmt]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_Insp]  DEFAULT ('') FOR [Insp]
GO
ALTER TABLE [dbo].[EmpSalary] ADD  CONSTRAINT [DF_EmpSalary_HeadName]  DEFAULT ('') FOR [HeadName]
GO
ALTER TABLE [dbo].[Experience] ADD  CONSTRAINT [DF_Experience_EmpAutoNo]  DEFAULT (0) FOR [EmpAutoNo]
GO
ALTER TABLE [dbo].[Experience] ADD  CONSTRAINT [DF_Experience_EmpId]  DEFAULT ('') FOR [EmpId]
GO
ALTER TABLE [dbo].[Experience] ADD  CONSTRAINT [DF_Experience_ExpID_1]  DEFAULT ('') FOR [ExpID]
GO
ALTER TABLE [dbo].[Experience] ADD  CONSTRAINT [DF_Experience_YearOfExperience]  DEFAULT (0) FOR [YearOfExp]
GO
ALTER TABLE [dbo].[Experience] ADD  CONSTRAINT [DF_Experience_SkillLevel]  DEFAULT ('') FOR [Skill]
GO
ALTER TABLE [dbo].[Experience] ADD  CONSTRAINT [DF_Experience_Company]  DEFAULT ('') FOR [Company]
GO
ALTER TABLE [dbo].[Experience] ADD  CONSTRAINT [DF_Experience_Responsibility]  DEFAULT ('') FOR [Responsibility]
GO
ALTER TABLE [dbo].[Experience] ADD  CONSTRAINT [DF_Experience_DesignationID]  DEFAULT ('') FOR [Designation]
GO
ALTER TABLE [dbo].[Experience] ADD  CONSTRAINT [DF_Experience_Description]  DEFAULT ('') FOR [Description]
GO
ALTER TABLE [dbo].[Experience] ADD  CONSTRAINT [DF_Experience_comid]  DEFAULT ('') FOR [ComID]
GO
ALTER TABLE [dbo].[Experience] ADD  CONSTRAINT [DF_Experience_PcName]  DEFAULT ('') FOR [PcName]
GO
ALTER TABLE [dbo].[Experience] ADD  CONSTRAINT [DF_Experience_UserCode]  DEFAULT (0) FOR [UserCode]
GO
ALTER TABLE [dbo].[Experience] ADD  CONSTRAINT [DF_Experience_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[ExpOfPurchase] ADD  CONSTRAINT [DF_ExpOfPurchase_SLNo]  DEFAULT (0) FOR [SLNo]
GO
ALTER TABLE [dbo].[ExpOfPurchase] ADD  CONSTRAINT [DF_ExpOfPurchase_HeadName]  DEFAULT ('') FOR [HeadName]
GO
ALTER TABLE [dbo].[ExpOfPurchase] ADD  CONSTRAINT [DF_ExpOfPurchase_Amt]  DEFAULT (0) FOR [Amt]
GO
ALTER TABLE [dbo].[ExpOfPurchase] ADD  CONSTRAINT [DF_ExpOfPurchase_PurchaseAutoNO]  DEFAULT (0) FOR [PurchaseAutoNO]
GO
ALTER TABLE [dbo].[ExpOfPurchase] ADD  CONSTRAINT [DF_ExpOfPurchase_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[ExpOfPurchase] ADD  CONSTRAINT [DF_ExpOfPurchase_Cur]  DEFAULT ('') FOR [Cur]
GO
ALTER TABLE [dbo].[ExpOfPurchase] ADD  CONSTRAINT [DF__expofPurc__ConvR__44A01A3E]  DEFAULT (0) FOR [ConvRate]
GO
ALTER TABLE [dbo].[FamilyInfo] ADD  CONSTRAINT [DF_FamilyInfo_EmpAutoNo]  DEFAULT (0) FOR [EmpAutoNo]
GO
ALTER TABLE [dbo].[FeedBack] ADD  CONSTRAINT [DF__FeedBack__UserNa__3917F415]  DEFAULT ('') FOR [UserName]
GO
ALTER TABLE [dbo].[FeedBack] ADD  CONSTRAINT [DF__FeedBack__Rmk__3A0C184E]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[FeedBack] ADD  CONSTRAINT [DF__FeedBack__Sts__3B003C87]  DEFAULT (0) FOR [Sts]
GO
ALTER TABLE [dbo].[Grade] ADD  CONSTRAINT [DF_Grade_Name]  DEFAULT ('') FOR [Name]
GO
ALTER TABLE [dbo].[Grade] ADD  CONSTRAINT [DF_Grade_Bname]  DEFAULT ('') FOR [Bname]
GO
ALTER TABLE [dbo].[Grade] ADD  CONSTRAINT [DF_Grade_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[Grade] ADD  CONSTRAINT [DF_Grade_comid]  DEFAULT ('1') FOR [comid]
GO
ALTER TABLE [dbo].[Grade] ADD  CONSTRAINT [DF_Grade_PcName]  DEFAULT ('') FOR [PcName]
GO
ALTER TABLE [dbo].[Grade] ADD  CONSTRAINT [DF_Grade_UserCode]  DEFAULT (0) FOR [UserCode]
GO
ALTER TABLE [dbo].[Grade] ADD  CONSTRAINT [DF_Grade_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[Head] ADD  CONSTRAINT [DF_expHead_headName]  DEFAULT ('') FOR [HeadName]
GO
ALTER TABLE [dbo].[Head] ADD  CONSTRAINT [DF_Head_Type]  DEFAULT ('') FOR [Type]
GO
ALTER TABLE [dbo].[Head] ADD  CONSTRAINT [DF_Head_HGroup]  DEFAULT ('') FOR [HGroup]
GO
ALTER TABLE [dbo].[Head] ADD  CONSTRAINT [DF__head__Source__38EE7070]  DEFAULT ('') FOR [Source]
GO
ALTER TABLE [dbo].[Head] ADD  CONSTRAINT [DF_Head_AutoNo]  DEFAULT (0) FOR [AutoNo]
GO
ALTER TABLE [dbo].[Head] ADD  CONSTRAINT [DF__head__Master__7E0E6D1B]  DEFAULT ('') FOR [Master]
GO
ALTER TABLE [dbo].[Head] ADD  CONSTRAINT [DF_Head_PCName]  DEFAULT ('') FOR [PCName]
GO
ALTER TABLE [dbo].[Head] ADD  CONSTRAINT [DF_Head_BName]  DEFAULT ('') FOR [BName]
GO
ALTER TABLE [dbo].[Head] ADD  CONSTRAINT [DF_Head_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[Head] ADD  CONSTRAINT [DF_Head_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[Head] ADD  CONSTRAINT [DF_Head_UserCode]  DEFAULT ('') FOR [UserCode]
GO
ALTER TABLE [dbo].[Head] ADD  CONSTRAINT [DF_Head_SubHead]  DEFAULT ('') FOR [SubHead]
GO
ALTER TABLE [dbo].[Head] ADD  CONSTRAINT [DF_Head_OPBal]  DEFAULT (0) FOR [OPBal]
GO
ALTER TABLE [dbo].[Head] ADD  CONSTRAINT [DF_Head_TypeAutoNo]  DEFAULT (0) FOR [TypeAutoNo]
GO
ALTER TABLE [dbo].[HolidayCalender] ADD  CONSTRAINT [DF_HolidayCalender_HMonth]  DEFAULT ('') FOR [HMonth]
GO
ALTER TABLE [dbo].[HolidayCalender] ADD  CONSTRAINT [DF_HolidayCalender_HYear]  DEFAULT ('') FOR [HYear]
GO
ALTER TABLE [dbo].[HolidayCalender] ADD  CONSTRAINT [DF_HolidayCalender_HDay]  DEFAULT ('') FOR [HDay]
GO
ALTER TABLE [dbo].[HolidayCalender] ADD  CONSTRAINT [DF_HolidayCalender_Reason]  DEFAULT ('') FOR [Reason]
GO
ALTER TABLE [dbo].[HolidayCalender] ADD  CONSTRAINT [DF_HolidayCalender_FOpen]  DEFAULT (0) FOR [FOpen]
GO
ALTER TABLE [dbo].[HolidayCalender] ADD  CONSTRAINT [DF_HolidayCalender_PcName]  DEFAULT ('') FOR [PcName]
GO
ALTER TABLE [dbo].[HolidayCalender] ADD  CONSTRAINT [DF_HolidayCalender_UserCode]  DEFAULT ('') FOR [UserCode]
GO
ALTER TABLE [dbo].[HolidayCalender] ADD  CONSTRAINT [DF_HolidayCalender_ComId]  DEFAULT ('') FOR [ComId]
GO
ALTER TABLE [dbo].[HolidayCalender] ADD  CONSTRAINT [DF__HolidayCa__Entry__3E7D2C94]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[Increment] ADD  CONSTRAINT [DF_Increment_EmpAutoNo]  DEFAULT (0) FOR [EmpAutoNo]
GO
ALTER TABLE [dbo].[Increment] ADD  CONSTRAINT [DF__Increment__PrevS__4DB4832C]  DEFAULT (0) FOR [PrevSalary]
GO
ALTER TABLE [dbo].[Increment] ADD  CONSTRAINT [DF__Increment__Incre__4EA8A765]  DEFAULT (0) FOR [IncPerc]
GO
ALTER TABLE [dbo].[Increment] ADD  CONSTRAINT [DF__Increment__INC_A__4F9CCB9E]  DEFAULT (0) FOR [IncAmt]
GO
ALTER TABLE [dbo].[Increment] ADD  CONSTRAINT [DF_Increment_ForMonth]  DEFAULT ('') FOR [ForMonth]
GO
ALTER TABLE [dbo].[Increment] ADD  CONSTRAINT [DF_Increment_ForYear]  DEFAULT ('') FOR [ForYear]
GO
ALTER TABLE [dbo].[Increment] ADD  CONSTRAINT [DF__Increment__prevS__5090EFD7]  DEFAULT (0) FOR [prevSalaryDol]
GO
ALTER TABLE [dbo].[Increment] ADD  CONSTRAINT [DF__Increment__inc_a__51851410]  DEFAULT (0) FOR [IncAmtDol]
GO
ALTER TABLE [dbo].[Increment] ADD  CONSTRAINT [DF__increment__Based__30D918B3]  DEFAULT ('') FOR [BasedOn]
GO
ALTER TABLE [dbo].[Increment] ADD  CONSTRAINT [DF__increment__IncTy__3D14070F]  DEFAULT ('') FOR [IncType]
GO
ALTER TABLE [dbo].[Increment] ADD  CONSTRAINT [DF_Increment_Entrytime]  DEFAULT (getdate()) FOR [Entrytime]
GO
ALTER TABLE [dbo].[Increment] ADD  CONSTRAINT [DF_Increment_PcName]  DEFAULT ('') FOR [PcName]
GO
ALTER TABLE [dbo].[Increment] ADD  CONSTRAINT [DF_Increment_PresDesg]  DEFAULT (0) FOR [PresDesgCode]
GO
ALTER TABLE [dbo].[Increment] ADD  CONSTRAINT [DF_Increment_PrevDesg]  DEFAULT (0) FOR [PrevDesgCode]
GO
ALTER TABLE [dbo].[Increment] ADD  CONSTRAINT [DF_Increment_NewID]  DEFAULT ('') FOR [NewID]
GO
ALTER TABLE [dbo].[InstitutionInfo] ADD  CONSTRAINT [DF_InstitutionInfo_InstName]  DEFAULT ('') FOR [InstName]
GO
ALTER TABLE [dbo].[InstitutionInfo] ADD  CONSTRAINT [DF_InstitutionInfo_Address]  DEFAULT ('') FOR [Address]
GO
ALTER TABLE [dbo].[InstitutionInfo] ADD  CONSTRAINT [DF_InstitutionInfo_Area]  DEFAULT ('') FOR [Area]
GO
ALTER TABLE [dbo].[InstitutionInfo] ADD  CONSTRAINT [DF_InstitutionInfo_TypeOfSchool]  DEFAULT ('') FOR [Type]
GO
ALTER TABLE [dbo].[InstitutionInfo] ADD  CONSTRAINT [DF_InstitutionInfo_NumberOfTeacher]  DEFAULT (0) FOR [NumberOfTeacher]
GO
ALTER TABLE [dbo].[InstitutionInfo] ADD  CONSTRAINT [DF_InstitutionInfo_NumberOfStudent]  DEFAULT (0) FOR [NumberOfStudent]
GO
ALTER TABLE [dbo].[InstitutionInfo] ADD  CONSTRAINT [DF_InstitutionInfo_NumberOfEmp]  DEFAULT (0) FOR [NumberOfEmp]
GO
ALTER TABLE [dbo].[InstitutionInfo] ADD  CONSTRAINT [DF_InstitutionInfo_NORoom]  DEFAULT (0) FOR [NoOfRoom]
GO
ALTER TABLE [dbo].[InstitutionInfo] ADD  CONSTRAINT [DF_InstitutionInfo_NOFloor]  DEFAULT (0) FOR [NoOfFloor]
GO
ALTER TABLE [dbo].[InstitutionInfo] ADD  CONSTRAINT [DF_InstitutionInfo_Histry_1]  DEFAULT ('') FOR [Histry]
GO
ALTER TABLE [dbo].[InstitutionInfo] ADD  CONSTRAINT [DF_InstitutionInfo_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[InstitutionInfo] ADD  CONSTRAINT [DF_InstitutionInfo_ComId]  DEFAULT ('') FOR [ComId]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF__ITEM__ItemCode__1920BF5C]  DEFAULT (0) FOR [ItemCode]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF__ITEM__ItemName__1A14E395]  DEFAULT ('') FOR [ItemName]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF__ITEM__ItemType__1B0907CE]  DEFAULT ('') FOR [ItemType]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF__ITEM__ItemSize__1BFD2C07]  DEFAULT ('') FOR [ItemSize]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF_Item_ItemStyle]  DEFAULT ('') FOR [ItemStyle]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF_Item_Qty]  DEFAULT (0) FOR [OpBalQty]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF__ITEM__ROL__1DE57479]  DEFAULT (0) FOR [ROL]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF_Item_BarCode]  DEFAULT ('') FOR [BarCode]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF_Item_ComID]  DEFAULT ('') FOR [ComID]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF_Item_Unit]  DEFAULT ('') FOR [UnitID]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF_Item_PrifitAdd]  DEFAULT (0) FOR [ProfitAddWholeSale]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF_Item_ProfitAddRetailsSale]  DEFAULT (0) FOR [ProfitAddRetailSale]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF_Item_stockmaintain]  DEFAULT (1) FOR [stockMaintain]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF_Item_PCName]  DEFAULT ('') FOR [PCName]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF_Item_UserCode]  DEFAULT ('') FOR [UserCode]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF_Item_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF__Item__SalePrice__3BF460C0]  DEFAULT (0) FOR [SalePrice]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF__item__LatestPurc__4C2AC889]  DEFAULT (0) FOR [LatestPurchasePrice]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF__item__Active__4E1310FB]  DEFAULT (1) FOR [Active]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF__item__BName__4F073534]  DEFAULT ('') FOR [BName]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF_Item_Unit_1]  DEFAULT ('') FOR [Unit]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF_Item_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF__Item__Color__20D7ECDE]  DEFAULT ('') FOR [Color]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF_Item_CurName]  DEFAULT ('BDT') FOR [CurName]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF_Item_Model]  DEFAULT ('') FOR [Model]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF_Item_Vendor]  DEFAULT ('') FOR [Vendor]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF_Item_EndUnitQty]  DEFAULT (0) FOR [EndUnitQty]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF_Item_ManBarcode]  DEFAULT (0) FOR [ManBarcode]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF__item__OpValue__489B93AB]  DEFAULT (0) FOR [OpValue]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF_Item_CurStock]  DEFAULT (0) FOR [CurStock]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF__item__WholeSaleP__46535886]  DEFAULT (0) FOR [WholeSalePrice]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF__item__CardSalePr__47477CBF]  DEFAULT (0) FOR [CardSalePrice]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF__item__CreditSale__31233176]  DEFAULT (0) FOR [CreditSalePrice]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF__item__MRP__321755AF]  DEFAULT (0) FOR [MRP]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF__Item__ExpDate__37D02F05]  DEFAULT (0) FOR [ExpDate]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF__Item__PrSlNo__3BA0BFE9]  DEFAULT (0) FOR [PrSlNo]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF__Item__Warranty__5748DA5E]  DEFAULT (0) FOR [Warranty]
GO
ALTER TABLE [dbo].[ItemDelivery] ADD  CONSTRAINT [DF_ItemNew_ItemCode]  DEFAULT ('') FOR [ItemCode]
GO
ALTER TABLE [dbo].[ItemDelivery] ADD  CONSTRAINT [DF_ItemNew_Qty]  DEFAULT (0) FOR [Qty]
GO
ALTER TABLE [dbo].[ItemDelivery] ADD  CONSTRAINT [DF_ItemDelivery_DelNo]  DEFAULT ('') FOR [DelNo]
GO
ALTER TABLE [dbo].[ItemDelivery] ADD  CONSTRAINT [DF_ItemDelivery_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[ItemDelivery] ADD  CONSTRAINT [DF_ItemDelivery_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[ItemDelivery] ADD  CONSTRAINT [DF_ItemDelivery_ItemAutoNO]  DEFAULT (0) FOR [ItemAutoNO]
GO
ALTER TABLE [dbo].[ItemDelivery] ADD  CONSTRAINT [DF__itemdeliv__ComID__0717E911]  DEFAULT ('1') FOR [ComID]
GO
ALTER TABLE [dbo].[ItemDelivery] ADD  CONSTRAINT [DF__ItemDelive__Type__12899BBD]  DEFAULT ('') FOR [Type]
GO
ALTER TABLE [dbo].[ItemDelivery] ADD  CONSTRAINT [DF_ItemDelivery_BatchNo]  DEFAULT ('') FOR [BatchNo]
GO
ALTER TABLE [dbo].[ItemDelivery] ADD  CONSTRAINT [DF_ItemDelivery_RecQty]  DEFAULT (0) FOR [RecQty]
GO
ALTER TABLE [dbo].[ItemDelivery] ADD  CONSTRAINT [DF_ItemDelivery_RetQty]  DEFAULT (0) FOR [RetQty]
GO
ALTER TABLE [dbo].[ItemDelivery] ADD  CONSTRAINT [DF_ItemDelivery_DamQty]  DEFAULT (0) FOR [DamQty]
GO
ALTER TABLE [dbo].[ItemDelivery] ADD  CONSTRAINT [DF_ItemDelivery_UnitPrice]  DEFAULT (0) FOR [UnitPrice]
GO
ALTER TABLE [dbo].[ItemDelivery] ADD  CONSTRAINT [DF_ItemDelivery_TotalPrice]  DEFAULT (0) FOR [TotalPrice]
GO
ALTER TABLE [dbo].[ItemDelivery] ADD  CONSTRAINT [DF__itemdelive__SLNo__259C7031]  DEFAULT (0) FOR [SLNo]
GO
ALTER TABLE [dbo].[ItemDelivery] ADD  CONSTRAINT [DF_ItemDelivery_PCName]  DEFAULT ('') FOR [PCName]
GO
ALTER TABLE [dbo].[ItemReturn] ADD  CONSTRAINT [DF_ItemReturn_RetCode]  DEFAULT ('') FOR [RetCode]
GO
ALTER TABLE [dbo].[ItemReturn] ADD  CONSTRAINT [DF__ItemRetur__Invoi__47A6A41B]  DEFAULT ('') FOR [InvoiceNo]
GO
ALTER TABLE [dbo].[ItemReturn] ADD  CONSTRAINT [DF__ItemReturn__SLNo__489AC854]  DEFAULT ('') FOR [SLNo]
GO
ALTER TABLE [dbo].[ItemReturn] ADD  CONSTRAINT [DF__ItemRetur__ItemC__498EEC8D]  DEFAULT ('') FOR [ItemCode]
GO
ALTER TABLE [dbo].[ItemReturn] ADD  CONSTRAINT [DF__ItemReturn__Qty__4A8310C6]  DEFAULT (0) FOR [RetQty]
GO
ALTER TABLE [dbo].[ItemReturn] ADD  CONSTRAINT [DF__ItemRetur__UnitP__4B7734FF]  DEFAULT (0) FOR [UnitPrice]
GO
ALTER TABLE [dbo].[ItemReturn] ADD  CONSTRAINT [DF__ItemRetur__TotPr__4C6B5938]  DEFAULT (0) FOR [TotPrice]
GO
ALTER TABLE [dbo].[ItemReturn] ADD  CONSTRAINT [DF__ItemRetur__PcNam__4E53A1AA]  DEFAULT ('') FOR [PcName]
GO
ALTER TABLE [dbo].[ItemReturn] ADD  CONSTRAINT [DF_ItemReturn_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[ItemReturn] ADD  CONSTRAINT [DF_ItemReturn_ComId]  DEFAULT ('') FOR [ComId]
GO
ALTER TABLE [dbo].[ItemReturn] ADD  CONSTRAINT [DF_ItemReturn_ItemAutoNo]  DEFAULT (0) FOR [ItemAutoNo]
GO
ALTER TABLE [dbo].[ItemUnit] ADD  CONSTRAINT [DF_ItemUnit_UnitId]  DEFAULT ('') FOR [UnitId]
GO
ALTER TABLE [dbo].[ItemUnit] ADD  CONSTRAINT [DF_ItemUnit_UnitName]  DEFAULT ('') FOR [UnitName]
GO
ALTER TABLE [dbo].[ItemUnit] ADD  CONSTRAINT [DF_ItemUnit_Qty]  DEFAULT (1) FOR [Qty]
GO
ALTER TABLE [dbo].[ItemUnit] ADD  CONSTRAINT [DF_ItemUnit_ComId]  DEFAULT ('1') FOR [ComId]
GO
ALTER TABLE [dbo].[Job] ADD  CONSTRAINT [DF_Job_JobCardNo]  DEFAULT ('') FOR [JobCardNo]
GO
ALTER TABLE [dbo].[Job] ADD  CONSTRAINT [DF_Job_jobdescription]  DEFAULT ('') FOR [Jobdescription]
GO
ALTER TABLE [dbo].[Job] ADD  CONSTRAINT [DF_Job_client]  DEFAULT ('') FOR [Client]
GO
ALTER TABLE [dbo].[Job] ADD  CONSTRAINT [DF_Job_QTY]  DEFAULT (0) FOR [QTY]
GO
ALTER TABLE [dbo].[Job] ADD  CONSTRAINT [DF_Job_Unit]  DEFAULT ('') FOR [Unit]
GO
ALTER TABLE [dbo].[Job] ADD  CONSTRAINT [DF_Job_SuppliedQty]  DEFAULT (0) FOR [SuppliedQty]
GO
ALTER TABLE [dbo].[Job] ADD  CONSTRAINT [DF_Job_Satatus]  DEFAULT ('') FOR [Status]
GO
ALTER TABLE [dbo].[Job] ADD  CONSTRAINT [DF_Job_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[JobRmk] ADD  CONSTRAINT [DF_JobRmk_SectionId_1]  DEFAULT (0) FOR [SectionId]
GO
ALTER TABLE [dbo].[Leave] ADD  CONSTRAINT [DF_Leave_EmpAutoNo]  DEFAULT (0) FOR [EmpAutoNo]
GO
ALTER TABLE [dbo].[Leave] ADD  CONSTRAINT [DF_Leave_EmpID]  DEFAULT ('') FOR [EmpID]
GO
ALTER TABLE [dbo].[Leave] ADD  CONSTRAINT [DF_Leave_TypeOFLeave]  DEFAULT ('') FOR [TypeOFLeave]
GO
ALTER TABLE [dbo].[Leave] ADD  CONSTRAINT [DF_Leave_WithPayOrNot]  DEFAULT ('') FOR [WithPayOrNot]
GO
ALTER TABLE [dbo].[Leave] ADD  CONSTRAINT [DF_Leave_LQty]  DEFAULT (0) FOR [LQty]
GO
ALTER TABLE [dbo].[Leave] ADD  CONSTRAINT [DF_Leave_LIH]  DEFAULT (0) FOR [LIH]
GO
ALTER TABLE [dbo].[Leave] ADD  CONSTRAINT [DF_Leave_HalfQty]  DEFAULT (0) FOR [HalfQty]
GO
ALTER TABLE [dbo].[Leave] ADD  CONSTRAINT [DF_Leave_ComId]  DEFAULT ('') FOR [ComId]
GO
ALTER TABLE [dbo].[Leave] ADD  CONSTRAINT [DF__Leave__UserCode__48FABB07]  DEFAULT ('') FOR [UserCode]
GO
ALTER TABLE [dbo].[Leave] ADD  CONSTRAINT [DF__Leave__PcName__49EEDF40]  DEFAULT ('') FOR [PcName]
GO
ALTER TABLE [dbo].[Leave] ADD  CONSTRAINT [DF__Leave__EntryTime__4AE30379]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[LeaveBalance] ADD  CONSTRAINT [DF_LeaveBalance_EmpAutoNO]  DEFAULT (0) FOR [EmpAutoNO]
GO
ALTER TABLE [dbo].[LeaveBalance] ADD  CONSTRAINT [DF_LeaveBalance_EmpID]  DEFAULT ('') FOR [EmpID]
GO
ALTER TABLE [dbo].[LeaveBalance] ADD  CONSTRAINT [DF_LeaveBalance_ForYear]  DEFAULT ('') FOR [ForYear]
GO
ALTER TABLE [dbo].[LeaveBalance] ADD  CONSTRAINT [DF_LeaveBalance_SLAVL]  DEFAULT (0) FOR [SLAVL]
GO
ALTER TABLE [dbo].[LeaveBalance] ADD  CONSTRAINT [DF_LeaveBalance_CLAVL]  DEFAULT (0) FOR [CLAVL]
GO
ALTER TABLE [dbo].[LeaveBalance] ADD  CONSTRAINT [DF_LeaveBalance_ELAVL]  DEFAULT (0) FOR [ELAVL]
GO
ALTER TABLE [dbo].[LeaveBalance] ADD  CONSTRAINT [DF_LeaveBalance_SLFixed]  DEFAULT (0) FOR [SLFixed]
GO
ALTER TABLE [dbo].[LeaveBalance] ADD  CONSTRAINT [DF_LeaveBalance_CLFixed]  DEFAULT (0) FOR [CLFixed]
GO
ALTER TABLE [dbo].[LeaveBalance] ADD  CONSTRAINT [DF_LeaveBalance_ELFixed]  DEFAULT (0) FOR [ELFixed]
GO
ALTER TABLE [dbo].[LeaveBalance] ADD  CONSTRAINT [DF_LeaveBalance_CLBal]  DEFAULT (0) FOR [CLBal]
GO
ALTER TABLE [dbo].[LeaveBalance] ADD  CONSTRAINT [DF_LeaveBalance_SLBal]  DEFAULT (0) FOR [SLBal]
GO
ALTER TABLE [dbo].[LeaveBalance] ADD  CONSTRAINT [DF_LeaveBalance_ELBal]  DEFAULT (0) FOR [ELBal]
GO
ALTER TABLE [dbo].[LeaveBalance] ADD  CONSTRAINT [DF_LeaveBalance_ComId]  DEFAULT ('') FOR [ComId]
GO
ALTER TABLE [dbo].[LeaveBalance] ADD  CONSTRAINT [DF__LeaveBala__UserC__4BD727B2]  DEFAULT (0) FOR [UserCode]
GO
ALTER TABLE [dbo].[LeaveBalance] ADD  CONSTRAINT [DF__LeaveBala__PcNam__4CCB4BEB]  DEFAULT ('') FOR [PcName]
GO
ALTER TABLE [dbo].[LeaveBalance] ADD  CONSTRAINT [DF__LeaveBala__Entry__4DBF7024]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[LeaveTransaction] ADD  CONSTRAINT [DF_LeaveTransaction_EmpAutoNO]  DEFAULT (0) FOR [EmpAutoNO]
GO
ALTER TABLE [dbo].[LeaveTransaction] ADD  CONSTRAINT [DF_LeaveTransaction_EmpId]  DEFAULT ('') FOR [EmpId]
GO
ALTER TABLE [dbo].[LeaveTransaction] ADD  CONSTRAINT [DF_LeaveTransaction_TypeOfLeave]  DEFAULT ('') FOR [TypeOfLeave]
GO
ALTER TABLE [dbo].[LeaveTransaction] ADD  CONSTRAINT [DF_LeaveTransaction_WithPayorNot_1]  DEFAULT ('') FOR [WithPayorNot]
GO
ALTER TABLE [dbo].[LeaveTransaction] ADD  CONSTRAINT [DF_LeaveTransaction_TotalDays]  DEFAULT (0) FOR [TotalDays]
GO
ALTER TABLE [dbo].[LeaveTransaction] ADD  CONSTRAINT [DF_LeaveTransaction_HalfLeave]  DEFAULT (0) FOR [HalfLeave]
GO
ALTER TABLE [dbo].[LeaveTransaction] ADD  CONSTRAINT [DF_LeaveTransaction_Remarks]  DEFAULT ('') FOR [Remarks]
GO
ALTER TABLE [dbo].[LeaveTransaction] ADD  CONSTRAINT [DF_LeaveTransaction_LIH]  DEFAULT (0) FOR [LIH]
GO
ALTER TABLE [dbo].[LeaveTransaction] ADD  CONSTRAINT [DF_LeaveTransaction_ComId_1]  DEFAULT ('') FOR [ComId]
GO
ALTER TABLE [dbo].[LeaveTransaction] ADD  CONSTRAINT [DF__LeaveTran__UserC__4EB3945D]  DEFAULT ('') FOR [UserCode]
GO
ALTER TABLE [dbo].[LeaveTransaction] ADD  CONSTRAINT [DF__LeaveTran__PcNam__4FA7B896]  DEFAULT ('') FOR [PcName]
GO
ALTER TABLE [dbo].[LeaveTransaction] ADD  CONSTRAINT [DF__LeaveTran__Entry__509BDCCF]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[LeaveTransaction] ADD  CONSTRAINT [DF_LeaveTransaction_ForYear]  DEFAULT ('') FOR [ForYear]
GO
ALTER TABLE [dbo].[Line] ADD  CONSTRAINT [DF_Line_Name]  DEFAULT ('') FOR [Name]
GO
ALTER TABLE [dbo].[Line] ADD  CONSTRAINT [DF_Line_BName]  DEFAULT ('') FOR [BName]
GO
ALTER TABLE [dbo].[Line] ADD  CONSTRAINT [DF_Line_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[Line] ADD  CONSTRAINT [DF_Line_PcName]  DEFAULT ('') FOR [PcName]
GO
ALTER TABLE [dbo].[Line] ADD  CONSTRAINT [DF_Line_UserCode]  DEFAULT (0) FOR [UserCode]
GO
ALTER TABLE [dbo].[Line] ADD  CONSTRAINT [DF_Line_ComId]  DEFAULT ('1') FOR [ComId]
GO
ALTER TABLE [dbo].[Line] ADD  CONSTRAINT [DF_Line_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[Line] ADD  CONSTRAINT [DF_Line_ShortName]  DEFAULT ('') FOR [ShortName]
GO
ALTER TABLE [dbo].[LOG] ADD  CONSTRAINT [DF_LOG_UID]  DEFAULT ('') FOR [UID]
GO
ALTER TABLE [dbo].[LOG] ADD  CONSTRAINT [DF_LOG_THETIME]  DEFAULT (getdate()) FOR [THETIME]
GO
ALTER TABLE [dbo].[LOG] ADD  CONSTRAINT [DF_LOG_DESCRIPTION]  DEFAULT ('') FOR [DESCRIPTION]
GO
ALTER TABLE [dbo].[LOG] ADD  CONSTRAINT [DF_LOG_PCName]  DEFAULT ('') FOR [PCName]
GO
ALTER TABLE [dbo].[LOG] ADD  CONSTRAINT [DF_LOG_ComID]  DEFAULT ('') FOR [ComID]
GO
ALTER TABLE [dbo].[LoginUser] ADD  CONSTRAINT [DF_LoginUser_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[LtrSend] ADD  CONSTRAINT [DF__LtrSend__Address__206DA6C0]  DEFAULT ('') FOR [Address]
GO
ALTER TABLE [dbo].[LtrSend] ADD  CONSTRAINT [DF__LtrSend__PcName__2161CAF9]  DEFAULT ('') FOR [PcName]
GO
ALTER TABLE [dbo].[ManEdit] ADD  CONSTRAINT [DF_ManEdit_EmpID]  DEFAULT ('') FOR [EmpID]
GO
ALTER TABLE [dbo].[ManEdit] ADD  CONSTRAINT [DF_ManEdit_Rmk]  DEFAULT ('') FOR [IsManualType]
GO
ALTER TABLE [dbo].[ManEdit] ADD  CONSTRAINT [DF_ManEdit_TxtLine]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[ManEdit] ADD  CONSTRAINT [DF_ManEdit_EmpAutoNo]  DEFAULT (0) FOR [EmpAutoNo]
GO
ALTER TABLE [dbo].[ManEdit] ADD  CONSTRAINT [DF_ManEdit_ManualRmk]  DEFAULT ('') FOR [ManualRmk]
GO
ALTER TABLE [dbo].[MarksEntry] ADD  CONSTRAINT [DF_MarksEntry_StudentID]  DEFAULT ('') FOR [StudentID]
GO
ALTER TABLE [dbo].[MarksEntry] ADD  CONSTRAINT [DF_MarksEntry_ExamName]  DEFAULT ('') FOR [ExamName]
GO
ALTER TABLE [dbo].[MarksEntry] ADD  CONSTRAINT [DF_MarksEntry_ComID]  DEFAULT ('1') FOR [ComID]
GO
ALTER TABLE [dbo].[MarksEntry] ADD  CONSTRAINT [DF_MarksEntry_SubjCode]  DEFAULT (0) FOR [SubjCode]
GO
ALTER TABLE [dbo].[MarksEntry] ADD  CONSTRAINT [DF_MarksEntry_ShortMarks]  DEFAULT (0) FOR [ShortMarks]
GO
ALTER TABLE [dbo].[MarksEntry] ADD  CONSTRAINT [DF_MarksEntry_BroadMarks]  DEFAULT (0) FOR [BroadMarks]
GO
ALTER TABLE [dbo].[MarksEntry] ADD  CONSTRAINT [DF_MarksEntry_Result]  DEFAULT ('') FOR [Result]
GO
ALTER TABLE [dbo].[MarksEntry] ADD  CONSTRAINT [DF_MarksEntry_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[MarksEntry] ADD  CONSTRAINT [DF_MarksEntry_PCName]  DEFAULT ('') FOR [PCName]
GO
ALTER TABLE [dbo].[MarksEntry] ADD  CONSTRAINT [DF_MarksEntry_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[MarksEntry] ADD  CONSTRAINT [DF_MarksEntry_UserCode]  DEFAULT (0) FOR [UserCode]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_EmpAutoNo]  DEFAULT (0) FOR [EmpAutoNo]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_ComId]  DEFAULT ('1') FOR [ComId]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_EmpId]  DEFAULT ('') FOR [EmpId]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_ForMonth]  DEFAULT ('') FOR [ForMonth]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_ForYear]  DEFAULT ('') FOR [ForYear]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_Gross]  DEFAULT (0) FOR [Gross]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_Basic]  DEFAULT (0) FOR [Basic]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_HRent]  DEFAULT (0) FOR [HRent]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_Allowance]  DEFAULT (0) FOR [Allowance]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_OTHour]  DEFAULT (0) FOR [OTHour]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_OTAmt]  DEFAULT (0) FOR [OTAmt]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_AttnBonus]  DEFAULT (0) FOR [AttnBonus]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_FBonus]  DEFAULT (0) FOR [FBonus]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_AttnDay]  DEFAULT (0) FOR [AttnDay]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_AbsDay]  DEFAULT (0) FOR [AbsDay]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_CL]  DEFAULT (0) FOR [CL]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_SL]  DEFAULT (0) FOR [SL]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_EL]  DEFAULT (0) FOR [EL]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_ML]  DEFAULT (0) FOR [ML]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_SPL]  DEFAULT (0) FOR [SPL]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_HoliDay]  DEFAULT (0) FOR [HoliDay]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_LDay]  DEFAULT (0) FOR [LDay]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_LMoney]  DEFAULT (0) FOR [LMoney]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_CDay]  DEFAULT (0) FOR [CDay]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_CMoney]  DEFAULT (0) FOR [CMoney]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_OthersAdd]  DEFAULT (0) FOR [OthersAdd]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_ELMoney]  DEFAULT (0) FOR [ELMoney]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_AdvDed]  DEFAULT (0) FOR [AdvDed]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_PFDedEmp]  DEFAULT (0) FOR [PFDedEmp]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_PFDedCom]  DEFAULT (0) FOR [PFDedCom]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_AbsDed]  DEFAULT (0) FOR [AbsDed]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_OthersDed]  DEFAULT (0) FOR [OthersDed]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_TotalEarn]  DEFAULT (0) FOR [TotalEarn]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_SectionID]  DEFAULT (0) FOR [SectionCode]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_DesignationID]  DEFAULT (0) FOR [DesignationCode]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_BlockID]  DEFAULT (0) FOR [LineCode]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_GradeID]  DEFAULT (0) FOR [GradeCode]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_DepartmentCode]  DEFAULT (0) FOR [DepartmentCode]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_totalDed]  DEFAULT (0) FOR [TotalDed]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_netPay]  DEFAULT (0) FOR [NetPay]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_extraOtHour]  DEFAULT (0) FOR [ExtraOtHour]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_extraOtAmt]  DEFAULT (0) FOR [ExtraOtAmt]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_slDed]  DEFAULT (0) FOR [SLDed]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_leftworker]  DEFAULT (0) FOR [leftworker]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__tk500__6991A7CB]  DEFAULT (0) FOR [tk500]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__tk100__6A85CC04]  DEFAULT (0) FOR [tk100]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__tk50__6B79F03D]  DEFAULT (0) FOR [tk50]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__tk20__6C6E1476]  DEFAULT (0) FOR [tk20]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__tk10__6D6238AF]  DEFAULT (0) FOR [tk10note]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__tk5__6E565CE8]  DEFAULT (0) FOR [tk5]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__tk2__6F4A8121]  DEFAULT (0) FOR [tk2note]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__tk1__703EA55A]  DEFAULT (0) FOR [tk1note]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__Fract__4242D080]  DEFAULT (0) FOR [Fraction]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__Unpai__2A363CC5]  DEFAULT (0) FOR [Unpaid]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__MONSALARY__UNPAI__69279377]  DEFAULT (0) FOR [UNPAIDOT]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__MONSALARY__notic__6B0FDBE9]  DEFAULT (0) FOR [noticepay]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__seper__4D4A6ED8]  DEFAULT (0) FOR [seperate]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__TEM1__4E3E9311]  DEFAULT (0) FOR [TEM1]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__TEM2__4F32B74A]  DEFAULT ('') FOR [SalGrp]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__TEM3__5026DB83]  DEFAULT (0) FOR [Bank]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__PFLoa__69678A99]  DEFAULT (0) FOR [PFLoan]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_PFInt]  DEFAULT (0) FOR [PFInt]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_ExtraLunchDay]  DEFAULT (0) FOR [ExtraLunchDay]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_ExtraLunchAmt]  DEFAULT (0) FOR [ExtraLunchAmt]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_othersAddOt]  DEFAULT (0) FOR [othersAddOt]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_othersDedOt]  DEFAULT (0) FOR [othersDedOt]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_leftSheet]  DEFAULT (0) FOR [leftSheet]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__OtHrP__2D0887CF]  DEFAULT (0) FOR [OtHrPvh]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__OtAmt__2DFCAC08]  DEFAULT (0) FOR [OtAmtPvh]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__Gross__33B5855E]  DEFAULT (0) FOR [GrossB]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__OThou__34A9A997]  DEFAULT (0) FOR [OThourB]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__OTAmt__359DCDD0]  DEFAULT (0) FOR [OTAmtB]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__PFded__3691F209]  DEFAULT (0) FOR [PFdedEmpB]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__Total__37861642]  DEFAULT (0) FOR [TotalEarnB]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__NetPa__387A3A7B]  DEFAULT (0) FOR [NetPayB]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__Desig__396E5EB4]  DEFAULT ('') FOR [DesigIDB]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__Grade__3A6282ED]  DEFAULT ('') FOR [GradeIDB]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__absde__3B56A726]  DEFAULT (0) FOR [absdedB]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__Total__3C4ACB5F]  DEFAULT (0) FOR [TotalDedB]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__Payty__4D2051A6]  DEFAULT ('') FOR [Paytype]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__MONSALARY__GD__22F50DB0]  DEFAULT (0) FOR [GD]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__MONSALARY__ATTND__23E931E9]  DEFAULT (0) FOR [ATTNDayB]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__MONSALARY__HDayB__24DD5622]  DEFAULT (0) FOR [HDayB]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__MONSALARY__AbsDa__25D17A5B]  DEFAULT (0) FOR [AbsDayb]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__Shift__2C496DC0]  DEFAULT ('') FOR [Shift]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_TaDa]  DEFAULT (0) FOR [TaDa]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_MeetingBill]  DEFAULT (0) FOR [MeetingBill]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_IncomeTax]  DEFAULT (0) FOR [IncomeTax]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_MobileBill]  DEFAULT (0) FOR [MobileBill]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_MotorCycle]  DEFAULT (0) FOR [MotorCycle]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_LWPay]  DEFAULT (0) FOR [LWPay]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_FacUnitId]  DEFAULT ('') FOR [FacUnitId]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__Gross__2818EA29]  DEFAULT (0) FOR [GrosssUsd]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__MOnsalary__Gross__2A01329B]  DEFAULT (0) FOR [GrossUsd]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__MOnsalary__TkOne__2AF556D4]  DEFAULT (0) FOR [TkOneThousand]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__PayBa__7B4643B2]  DEFAULT (0) FOR [PayBasic]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__PayHR__7C3A67EB]  DEFAULT (0) FOR [PayHRent]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__PayMe__7D2E8C24]  DEFAULT (0) FOR [PayMedical]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__PayGr__7E22B05D]  DEFAULT (0) FOR [PayGross]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__Type__09946309]  DEFAULT ('') FOR [Type]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__IncDe__1411F17C]  DEFAULT (0) FOR [IncDed]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__LWP__150615B5]  DEFAULT (0) FOR [LWP]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_UserCode]  DEFAULT (0) FOR [UserCode]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_PcName]  DEFAULT ('') FOR [PcName]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF_MonSalary_Entrytime]  DEFAULT (getdate()) FOR [Entrytime]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__MonSalary__Month__715DE3E6]  DEFAULT (0) FOR [MonthDay]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__MonSalary__WorkD__7252081F]  DEFAULT (0) FOR [WorkDay]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__MonSalary__Salar__73462C58]  DEFAULT (0) FOR [SalaryDay]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__MonSalary__GovHo__743A5091]  DEFAULT (0) FOR [GovHoliDay]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__MonSalary__PageS__752E74CA]  DEFAULT (0) FOR [PageSlNo]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__MonSalary__Stamp__76229903]  DEFAULT (0) FOR [Stamp]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__MonSalary__Medic__7716BD3C]  DEFAULT (0) FOR [Medical]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__MonSalary__OTRat__780AE175]  DEFAULT (0) FOR [OTRate]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__MonSalary__Extra__78FF05AE]  DEFAULT (0) FOR [ExtraOTRate]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__MonSalary__TA__79F329E7]  DEFAULT (0) FOR [TA]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__MonSalary__Food__7AE74E20]  DEFAULT (0) FOR [Food]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__MonSalary__IncAm__7BDB7259]  DEFAULT (0) FOR [IncAmt]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__MonSalary__PayAb__7CCF9692]  DEFAULT (0) FOR [PayAbleSalary]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__SalTy__4C764630]  DEFAULT ('') FOR [SalType]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__Basic__4D6A6A69]  DEFAULT (0) FOR [BasicB]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__HRent__4E5E8EA2]  DEFAULT (0) FOR [HRentB]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__Medic__4F52B2DB]  DEFAULT (0) FOR [MedicalB]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__ProdA__5046D714]  DEFAULT (0) FOR [ProdAmt]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__ProdQ__513AFB4D]  DEFAULT (0) FOR [ProdQty]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__SrNo__73079A1A]  DEFAULT (0) FOR [SrNo]
GO
ALTER TABLE [dbo].[MonSalary] ADD  CONSTRAINT [DF__monsalary__OffDa__0249DDAA]  DEFAULT (0) FOR [OffDay]
GO
ALTER TABLE [dbo].[MonthlyAttn] ADD  CONSTRAINT [DF_MonthlyAttn_EmpIDAutoNo]  DEFAULT (0) FOR [EmpAutoNo]
GO
ALTER TABLE [dbo].[MonthlyAttn] ADD  CONSTRAINT [DF_MonthlyAttn_TotAttnDay]  DEFAULT (0) FOR [TotAttnDay]
GO
ALTER TABLE [dbo].[MonthlyAttn] ADD  CONSTRAINT [DF_MonthlyAttn_OTHr]  DEFAULT (0) FOR [OTHr]
GO
ALTER TABLE [dbo].[MonthlyAttn] ADD  CONSTRAINT [DF_MonthlyAttn_ExtraOT]  DEFAULT (0) FOR [ExtraOT]
GO
ALTER TABLE [dbo].[MonthlyAttn] ADD  CONSTRAINT [DF_MonthlyAttn_TotHoliday]  DEFAULT (0) FOR [TotHoliday]
GO
ALTER TABLE [dbo].[MonthlyAttn] ADD  CONSTRAINT [DF_MonthlyAttn_OthersAdd]  DEFAULT (0) FOR [OthersAdd]
GO
ALTER TABLE [dbo].[MonthlyAttn] ADD  CONSTRAINT [DF_MonthlyAttn_OthersDeduct]  DEFAULT (0) FOR [OthersDeduct]
GO
ALTER TABLE [dbo].[MonthlyAttn] ADD  CONSTRAINT [DF_MonthlyAttn_AddRmk]  DEFAULT ('') FOR [AddRmk]
GO
ALTER TABLE [dbo].[MonthlyAttn] ADD  CONSTRAINT [DF_MonthlyAttn_DeductRmk]  DEFAULT ('') FOR [DeductRmk]
GO
ALTER TABLE [dbo].[MonthlyAttn] ADD  CONSTRAINT [DF_MonthlyAttn_PCName]  DEFAULT ('') FOR [PCName]
GO
ALTER TABLE [dbo].[MonthlyAttn] ADD  CONSTRAINT [DF_MonthlyAttn_UserCode]  DEFAULT (0) FOR [UserCode]
GO
ALTER TABLE [dbo].[MonthlyAttn] ADD  CONSTRAINT [DF_MonthlyAttn_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[MonthlyAttn] ADD  CONSTRAINT [DF_MonthlyAttn_Manual]  DEFAULT (0) FOR [Manual]
GO
ALTER TABLE [dbo].[MonthlyAttn] ADD  CONSTRAINT [DF_MonthlyAttn_OTAdd]  DEFAULT (0) FOR [OTAdd]
GO
ALTER TABLE [dbo].[MonthlyAttn] ADD  CONSTRAINT [DF_MonthlyAttn_OTDed]  DEFAULT (0) FOR [OTDed]
GO
ALTER TABLE [dbo].[MonthlyAttn] ADD  CONSTRAINT [DF__monthlyat__Trans__550B8C31]  DEFAULT (0) FOR [Transport]
GO
ALTER TABLE [dbo].[MonthlyPcsEntry] ADD  CONSTRAINT [DF_MonthlyPcsEntry_ForMonth]  DEFAULT ('') FOR [ForMonth]
GO
ALTER TABLE [dbo].[MonthlyPcsEntry] ADD  CONSTRAINT [DF_MonthlyPcsEntry_ForYear]  DEFAULT ('') FOR [ForYear]
GO
ALTER TABLE [dbo].[MonthlyPcsEntry] ADD  CONSTRAINT [DF_MonthlyPcsEntry_EmpAutoNo]  DEFAULT (0) FOR [EmpAutoNo]
GO
ALTER TABLE [dbo].[MonthlyPcsEntry] ADD  CONSTRAINT [DF_MonthlyPcsEntry_StyleAutoNo]  DEFAULT (0) FOR [StyleAutoNo]
GO
ALTER TABLE [dbo].[MonthlyPcsEntry] ADD  CONSTRAINT [DF_MonthlyPcsEntry_Qty]  DEFAULT (0) FOR [Qty]
GO
ALTER TABLE [dbo].[MonthlyPcsEntry] ADD  CONSTRAINT [DF_MonthlyPcsEntry_Rate]  DEFAULT (0) FOR [Rate]
GO
ALTER TABLE [dbo].[MonthlyPcsEntry] ADD  CONSTRAINT [DF_MonthlyPcsEntry_PCName]  DEFAULT ('') FOR [PCName]
GO
ALTER TABLE [dbo].[MonthlyPcsEntry] ADD  CONSTRAINT [DF_MonthlyPcsEntry_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[MonthlyPcsEntry] ADD  CONSTRAINT [DF_MonthlyPcsEntry_UserCode]  DEFAULT ('') FOR [UserCode]
GO
ALTER TABLE [dbo].[MonthlyPcsEntry] ADD  CONSTRAINT [DF_MonthlyPcsEntry_ComID]  DEFAULT ('1') FOR [ComID]
GO
ALTER TABLE [dbo].[MonthlyPcsEntry] ADD  CONSTRAINT [DF__monthlypc__Total__48A5B54C]  DEFAULT (0) FOR [Total]
GO
ALTER TABLE [dbo].[MonthlySetup] ADD  CONSTRAINT [DF_MonthySetup_ForMonth]  DEFAULT ('') FOR [ForMonth]
GO
ALTER TABLE [dbo].[MonthlySetup] ADD  CONSTRAINT [DF_MonthySetup_ForYear]  DEFAULT ('') FOR [ForYear]
GO
ALTER TABLE [dbo].[MonthlySetup] ADD  CONSTRAINT [DF_MonthySetup_DollarRate]  DEFAULT (0) FOR [DollarRate]
GO
ALTER TABLE [dbo].[MonthlySetup] ADD  CONSTRAINT [DF_MonthySetup_MDays]  DEFAULT (0) FOR [MDays]
GO
ALTER TABLE [dbo].[MonthlySetup] ADD  CONSTRAINT [DF_MonthySetup_MNo]  DEFAULT (0) FOR [MNo]
GO
ALTER TABLE [dbo].[MonthlySetup] ADD  CONSTRAINT [DF_MonthySetup_ComID]  DEFAULT ('') FOR [ComID]
GO
ALTER TABLE [dbo].[MonthlySetup] ADD  CONSTRAINT [DF_MonthySetup_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[MonthlySetup] ADD  CONSTRAINT [DF_MonthySetup_SPLock]  DEFAULT (0) FOR [SPLock]
GO
ALTER TABLE [dbo].[MonthlySetup] ADD  CONSTRAINT [DF__monthlyse__ForMo__65CC03DF]  DEFAULT ('') FOR [ForMonthBangla]
GO
ALTER TABLE [dbo].[MonthlyTbl] ADD  CONSTRAINT [DF_MonthlyTbl_ForYear]  DEFAULT ('') FOR [ForYear]
GO
ALTER TABLE [dbo].[MonthlyTbl] ADD  CONSTRAINT [DF_MonthlyTbl_ForMonth]  DEFAULT ('') FOR [ForMonth]
GO
ALTER TABLE [dbo].[MonthlyTbl] ADD  CONSTRAINT [DF_MonthlyTbl_MonthNo]  DEFAULT (0) FOR [MonthNo]
GO
ALTER TABLE [dbo].[MonthlyTbl] ADD  CONSTRAINT [DF_MonthlyTbl_MothdDay]  DEFAULT (0) FOR [MonthDays]
GO
ALTER TABLE [dbo].[MonthlyTbl] ADD  CONSTRAINT [DF_MonthlyTbl_DollarRate]  DEFAULT (0) FOR [DollarRate]
GO
ALTER TABLE [dbo].[MonthlyTbl] ADD  CONSTRAINT [DF__monthlyTb__BName__58DC1D15]  DEFAULT ('') FOR [BName]
GO
ALTER TABLE [dbo].[OTEdit] ADD  CONSTRAINT [DF_OTEdit_EmpID]  DEFAULT ('') FOR [EmpID]
GO
ALTER TABLE [dbo].[OTEdit] ADD  CONSTRAINT [DF_OTEdit_Add]  DEFAULT (0) FOR [OT]
GO
ALTER TABLE [dbo].[OTEdit] ADD  CONSTRAINT [DF_OTEdit_Typ]  DEFAULT ('') FOR [Typ]
GO
ALTER TABLE [dbo].[OTEdit] ADD  CONSTRAINT [DF_OTEdit_Hol]  DEFAULT (0) FOR [Hol]
GO
ALTER TABLE [dbo].[PartyBranch] ADD  CONSTRAINT [DF_Table1_SLNo]  DEFAULT (0) FOR [SLNo]
GO
ALTER TABLE [dbo].[PartyBranch] ADD  CONSTRAINT [DF_Table1_BranchName]  DEFAULT ('') FOR [BranchName]
GO
ALTER TABLE [dbo].[PartyBranch] ADD  CONSTRAINT [DF_Table1_Address]  DEFAULT ('') FOR [Address]
GO
ALTER TABLE [dbo].[PartyBranch] ADD  CONSTRAINT [DF_Table1_ContPerson]  DEFAULT ('') FOR [ContPerson]
GO
ALTER TABLE [dbo].[PartyBranch] ADD  CONSTRAINT [DF_Table1_Phone]  DEFAULT ('') FOR [Phone]
GO
ALTER TABLE [dbo].[PartyBranch] ADD  CONSTRAINT [DF_Table1_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[PartyBranch] ADD  CONSTRAINT [DF_Table1_UserCode]  DEFAULT ('') FOR [UserCode]
GO
ALTER TABLE [dbo].[PartyInfo] ADD  CONSTRAINT [DF__PartyInfo__Party__3E52440B]  DEFAULT ('') FOR [PartyCode]
GO
ALTER TABLE [dbo].[PartyInfo] ADD  CONSTRAINT [DF__PartyInfo__Party__3F466844]  DEFAULT ('') FOR [PartyName]
GO
ALTER TABLE [dbo].[PartyInfo] ADD  CONSTRAINT [DF__PartyInfo__Addre__403A8C7D]  DEFAULT ('') FOR [Address]
GO
ALTER TABLE [dbo].[PartyInfo] ADD  CONSTRAINT [DF__PartyInfo__Party__412EB0B6]  DEFAULT ('') FOR [PartyType]
GO
ALTER TABLE [dbo].[PartyInfo] ADD  CONSTRAINT [DF__PartyInfo__Mobil__4222D4EF]  DEFAULT ('') FOR [MobileNo]
GO
ALTER TABLE [dbo].[PartyInfo] ADD  CONSTRAINT [DF__PartyInfo__Email__4316F928]  DEFAULT ('') FOR [Email]
GO
ALTER TABLE [dbo].[PartyInfo] ADD  CONSTRAINT [DF__PartyInfo__Conta__440B1D61]  DEFAULT ('') FOR [ContactPerson]
GO
ALTER TABLE [dbo].[PartyInfo] ADD  CONSTRAINT [DF_PartyInfo_AcctHead]  DEFAULT ('') FOR [AcctHead]
GO
ALTER TABLE [dbo].[PartyInfo] ADD  CONSTRAINT [DF__PARTYINFO__RMK__324172E1]  DEFAULT ('') FOR [RMK]
GO
ALTER TABLE [dbo].[PartyInfo] ADD  CONSTRAINT [DF__PARTYINFO__Contr__3335971A]  DEFAULT (0) FOR [ContractMoney]
GO
ALTER TABLE [dbo].[PartyInfo] ADD  CONSTRAINT [DF__PARTYINFO__Adv__3429BB53]  DEFAULT (0) FOR [Adv]
GO
ALTER TABLE [dbo].[PartyInfo] ADD  CONSTRAINT [DF__PARTYINFO__Due__351DDF8C]  DEFAULT (0) FOR [Due]
GO
ALTER TABLE [dbo].[PartyInfo] ADD  CONSTRAINT [DF__PARTYINFO__Compa__370627FE]  DEFAULT ('') FOR [ComId]
GO
ALTER TABLE [dbo].[PartyInfo] ADD  CONSTRAINT [DF_PartyInfo_PayMode]  DEFAULT ('') FOR [PayMode]
GO
ALTER TABLE [dbo].[PartyInfo] ADD  CONSTRAINT [DF__PartyInfo__Maste__00EAD9C6]  DEFAULT ('') FOR [Master]
GO
ALTER TABLE [dbo].[PartyInfo] ADD  CONSTRAINT [DF_PartyInfo_DisPerc]  DEFAULT (0) FOR [DisPerc]
GO
ALTER TABLE [dbo].[PartyInfo] ADD  CONSTRAINT [DF_PartyInfo_DrCr]  DEFAULT ('Dr') FOR [DrCr]
GO
ALTER TABLE [dbo].[PartyInfo] ADD  CONSTRAINT [DF_PartyInfo_OPBal]  DEFAULT (0) FOR [OPBal]
GO
ALTER TABLE [dbo].[PartyInfo] ADD  CONSTRAINT [DF_PartyInfo_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[PartyInfo] ADD  CONSTRAINT [DF_PartyInfo_PCName]  DEFAULT ('') FOR [PCName]
GO
ALTER TABLE [dbo].[PartyInfo] ADD  CONSTRAINT [DF_PartyInfo_UserName]  DEFAULT ('') FOR [UserCode]
GO
ALTER TABLE [dbo].[PartyInfo] ADD  CONSTRAINT [DF_PartyInfo_CrLimit]  DEFAULT (0) FOR [CrLimit]
GO
ALTER TABLE [dbo].[PartyInfo] ADD  CONSTRAINT [DF_PartyInfo_PassportNo]  DEFAULT ('') FOR [PassportNo]
GO
ALTER TABLE [dbo].[PartyInfo] ADD  CONSTRAINT [DF_PartyInfo_DrvLiscNo]  DEFAULT ('') FOR [DrvLiscNo]
GO
ALTER TABLE [dbo].[PartyInfo] ADD  CONSTRAINT [DF_PartyInfo_PhoneNo]  DEFAULT ('') FOR [PhoneNo]
GO
ALTER TABLE [dbo].[PartyInfo] ADD  CONSTRAINT [DF_PartyInfo_CurName]  DEFAULT ('BDT') FOR [CurName]
GO
ALTER TABLE [dbo].[PartyInfo] ADD  CONSTRAINT [DF_PartyInfo_ShortName]  DEFAULT ('') FOR [ShortName]
GO
ALTER TABLE [dbo].[PartyInfo] ADD  CONSTRAINT [DF__partyinfo__BillM__43B879AB]  DEFAULT ('') FOR [BillMonth]
GO
ALTER TABLE [dbo].[PartyInfo] ADD  CONSTRAINT [DF__PartyInfo__sts__2D87AABC]  DEFAULT (0) FOR [sts]
GO
ALTER TABLE [dbo].[PartyInfo] ADD  DEFAULT ('') FOR [EmpId]
GO
ALTER TABLE [dbo].[PartyInfo] ADD  DEFAULT ('') FOR [BName]
GO
ALTER TABLE [dbo].[PartyInfo] ADD  DEFAULT ('') FOR [AreaCode]
GO
ALTER TABLE [dbo].[PartyInfo] ADD  DEFAULT ('') FOR [RoadNo]
GO
ALTER TABLE [dbo].[PartyInfo] ADD  DEFAULT ('') FOR [SlNo]
GO
ALTER TABLE [dbo].[Photo] ADD  CONSTRAINT [DF_Photo_CodeNo]  DEFAULT ('') FOR [EmpId]
GO
ALTER TABLE [dbo].[Photo] ADD  CONSTRAINT [DF__Photo__EmpAutoNo__0214D380]  DEFAULT (0) FOR [EmpAutoNo]
GO
ALTER TABLE [dbo].[PODtl] ADD  CONSTRAINT [DF_PODtl_AutoNoFromMstrTbl]  DEFAULT (0) FOR [AutoNoFromMstrTbl]
GO
ALTER TABLE [dbo].[PODtl] ADD  CONSTRAINT [DF_PODtl_ItemName]  DEFAULT ('') FOR [ItemName]
GO
ALTER TABLE [dbo].[PODtl] ADD  CONSTRAINT [DF_PODtl_ItemAutoNo]  DEFAULT (0) FOR [ItemAutoNo]
GO
ALTER TABLE [dbo].[PODtl] ADD  CONSTRAINT [DF_PODtl_ComId]  DEFAULT ('1') FOR [ComId]
GO
ALTER TABLE [dbo].[PODtl] ADD  CONSTRAINT [DF_PODtl_UnitPrice]  DEFAULT (0) FOR [UnitPrice]
GO
ALTER TABLE [dbo].[PODtl] ADD  CONSTRAINT [DF_PODtl_TotalPrice]  DEFAULT (0) FOR [TotalPrice]
GO
ALTER TABLE [dbo].[PODtl] ADD  CONSTRAINT [DF_PODtl_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[PODtl] ADD  CONSTRAINT [DF_PODtl_PCName]  DEFAULT ('') FOR [PCName]
GO
ALTER TABLE [dbo].[PODtl] ADD  CONSTRAINT [DF_PODtl_UserCode]  DEFAULT ('') FOR [UserCode]
GO
ALTER TABLE [dbo].[PODtl] ADD  CONSTRAINT [DF_PODtl_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[PODtl] ADD  CONSTRAINT [DF_PODtl_slNo]  DEFAULT (0) FOR [slNo]
GO
ALTER TABLE [dbo].[PODtl] ADD  CONSTRAINT [DF_PODtl_ItemCode]  DEFAULT ('') FOR [ItemCode]
GO
ALTER TABLE [dbo].[POMstr] ADD  CONSTRAINT [DF_POMstr_ComId]  DEFAULT ('1') FOR [ComId]
GO
ALTER TABLE [dbo].[POMstr] ADD  CONSTRAINT [DF_POMstr_PONo]  DEFAULT ('') FOR [PONo]
GO
ALTER TABLE [dbo].[POMstr] ADD  CONSTRAINT [DF_POMstr_SupplierName]  DEFAULT ('') FOR [SupplierName]
GO
ALTER TABLE [dbo].[POMstr] ADD  CONSTRAINT [DF_POMstr_SupplierAddress]  DEFAULT ('') FOR [SupplierAddress]
GO
ALTER TABLE [dbo].[POMstr] ADD  CONSTRAINT [DF_POMstr_SuppCode]  DEFAULT (0) FOR [PartyAutoNo]
GO
ALTER TABLE [dbo].[POMstr] ADD  CONSTRAINT [DF_POMstr_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[POMstr] ADD  CONSTRAINT [DF_POMstr_UserCode]  DEFAULT ('') FOR [UserCode]
GO
ALTER TABLE [dbo].[POMstr] ADD  CONSTRAINT [DF_POMstr_PCName]  DEFAULT ('') FOR [PCName]
GO
ALTER TABLE [dbo].[POMstr] ADD  CONSTRAINT [DF_POMstr_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[Project] ADD  CONSTRAINT [DF_Project_PrjCode]  DEFAULT ('') FOR [PrjCode]
GO
ALTER TABLE [dbo].[Project] ADD  CONSTRAINT [DF_Project_PrjName]  DEFAULT ('') FOR [PrjName]
GO
ALTER TABLE [dbo].[Project] ADD  CONSTRAINT [DF_Project_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[Project] ADD  CONSTRAINT [DF_Project_Type]  DEFAULT ('') FOR [Type]
GO
ALTER TABLE [dbo].[Project] ADD  CONSTRAINT [DF_Project_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[Project] ADD  CONSTRAINT [DF_Project_ComID]  DEFAULT ('1') FOR [ComID]
GO
ALTER TABLE [dbo].[Project] ADD  CONSTRAINT [DF__Project__UserCod__01944BAF]  DEFAULT ('') FOR [UserCode]
GO
ALTER TABLE [dbo].[Project] ADD  CONSTRAINT [DF__Project__PCName__02886FE8]  DEFAULT ('') FOR [PCName]
GO
ALTER TABLE [dbo].[ProjectDtl] ADD  CONSTRAINT [DF_ProjectDtl_AutoNoFromMstrTbl]  DEFAULT (0) FOR [AutoNoFromMstrTbl]
GO
ALTER TABLE [dbo].[ProjectDtl] ADD  CONSTRAINT [DF_ProjectDtl_ComID]  DEFAULT ('1') FOR [ComID]
GO
ALTER TABLE [dbo].[ProjectDtl] ADD  CONSTRAINT [DF_ProjectDetails_SlNo]  DEFAULT (0) FOR [SlNo]
GO
ALTER TABLE [dbo].[ProjectDtl] ADD  CONSTRAINT [DF_ProjectDetails_ItemAutoNo]  DEFAULT (0) FOR [ItemAutoNo]
GO
ALTER TABLE [dbo].[ProjectDtl] ADD  CONSTRAINT [DF_ProjectDetails_Qty]  DEFAULT (0) FOR [Qty]
GO
ALTER TABLE [dbo].[ProjectDtl] ADD  CONSTRAINT [DF_ProjectDtl_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[ProjectMstr] ADD  CONSTRAINT [DF_ProjectMstr_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_ItemCode]  DEFAULT ('') FOR [ItemCode]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_PartyCode]  DEFAULT ('') FOR [PartyCode]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_Qty]  DEFAULT (0) FOR [Qty]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_UnitPrice]  DEFAULT (0) FOR [UnitPrice]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_SalePrice]  DEFAULT (0) FOR [SalePrice]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_SalePriceCode]  DEFAULT ('') FOR [SalePriceCode]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_UserCode]  DEFAULT ('') FOR [UserCode]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_PCName]  DEFAULT ('') FOR [PCName]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_SlNo]  DEFAULT (0) FOR [SlNo]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_Barcode]  DEFAULT ('') FOR [Barcode]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_TotalPrice]  DEFAULT (0) FOR [TotalPrice]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_PSlNo]  DEFAULT ('') FOR [PSlNo]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_ItemAutoNo]  DEFAULT (0) FOR [ItemAutoNo]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF__Purchase__Manual__3572E547]  DEFAULT (0) FOR [ManualBarcode]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_WholeSalePrice]  DEFAULT (0) FOR [WholeSalePrice]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF__purchase__UID__19A0ADA0]  DEFAULT ('') FOR [UID]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_AutoNoFromPurMstr]  DEFAULT (0) FOR [AutoNoFromMstrTbl]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_UserId]  DEFAULT ('') FOR [UserId]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF__Purchase__Type__7FAC033D]  DEFAULT ('') FOR [Type]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_wrntySts]  DEFAULT (0) FOR [WrntySts]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_Cur]  DEFAULT ('') FOR [Cur]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF__purchase__ConvRa__41C3AD93]  DEFAULT (0) FOR [ConvRate]
GO
ALTER TABLE [dbo].[PurchaseMstr] ADD  CONSTRAINT [DF_PurchaseMstr_PurchaseCode]  DEFAULT (0) FOR [PurchaseCode]
GO
ALTER TABLE [dbo].[PurchaseMstr] ADD  CONSTRAINT [DF_PurchaseMstr_PurchaseDate]  DEFAULT (getdate()) FOR [PurchaseDate]
GO
ALTER TABLE [dbo].[PurchaseMstr] ADD  CONSTRAINT [DF_PurchaseMstr_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[PurchaseMstr] ADD  CONSTRAINT [DF_PurchaseMstr_TotalPrice]  DEFAULT (0) FOR [TotalPrice]
GO
ALTER TABLE [dbo].[PurchaseMstr] ADD  CONSTRAINT [DF_PurchaseMstr_PCNAME]  DEFAULT ('') FOR [PCNAME]
GO
ALTER TABLE [dbo].[PurchaseMstr] ADD  CONSTRAINT [DF_PurchaseMstr_ENTRYTIME]  DEFAULT (getdate()) FOR [ENTRYTIME]
GO
ALTER TABLE [dbo].[PurchaseMstr] ADD  CONSTRAINT [DF_PurchaseMstr_USERID]  DEFAULT ('') FOR [UserCode]
GO
ALTER TABLE [dbo].[PurchaseMstr] ADD  CONSTRAINT [DF_PurchaseMstr_CASH]  DEFAULT (0) FOR [CASH]
GO
ALTER TABLE [dbo].[PurchaseMstr] ADD  CONSTRAINT [DF_PurchaseMstr_DUE]  DEFAULT (0) FOR [DUE]
GO
ALTER TABLE [dbo].[PurchaseMstr] ADD  CONSTRAINT [DF_PurchaseMstr_VoucherNo]  DEFAULT ('') FOR [Post]
GO
ALTER TABLE [dbo].[PurchaseMstr] ADD  CONSTRAINT [DF__purchaseM__MemoN__347EC10E]  DEFAULT ('') FOR [MemoNo]
GO
ALTER TABLE [dbo].[PurchaseMstr] ADD  CONSTRAINT [DF_PurchaseMstr_PrjCode]  DEFAULT ('0') FOR [PrjCode]
GO
ALTER TABLE [dbo].[PurchaseMstr] ADD  CONSTRAINT [DF_PurchaseMstr_PartyAutoNo]  DEFAULT (0) FOR [PartyAutoNo]
GO
ALTER TABLE [dbo].[PurchaseMstr] ADD  CONSTRAINT [DF_PurchaseMstr_UserId_1]  DEFAULT ('') FOR [UserId]
GO
ALTER TABLE [dbo].[PurchaseMstr] ADD  CONSTRAINT [DF_PurchaseMstr_FactoryExp]  DEFAULT (0) FOR [FactoryExp]
GO
ALTER TABLE [dbo].[PurchaseMstr] ADD  CONSTRAINT [DF__Purchasems__Type__043BAE30]  DEFAULT ('') FOR [Type]
GO
ALTER TABLE [dbo].[PurchaseMstr] ADD  CONSTRAINT [DF_PurchaseMstr_PrjAutoNo]  DEFAULT (0) FOR [PrjAutoNo]
GO
ALTER TABLE [dbo].[PurchaseMstr] ADD  CONSTRAINT [DF_PurchaseMstr_VrNo]  DEFAULT ('') FOR [VrNo]
GO
ALTER TABLE [dbo].[PurchaseMstr] ADD  CONSTRAINT [DF__purchaseM__ConvR__40CF895A]  DEFAULT (0) FOR [ConvRate]
GO
ALTER TABLE [dbo].[PurchaseMstr] ADD  CONSTRAINT [DF_PurchaseMstr_oRDERNO]  DEFAULT ('') FOR [oRDERNO]
GO
ALTER TABLE [dbo].[PurchaseMstr] ADD  CONSTRAINT [DF__purchasem__CrHea__2BCA4AD3]  DEFAULT ('') FOR [CrHead]
GO
ALTER TABLE [dbo].[PurchaseRet] ADD  CONSTRAINT [DF_PurchaseRet_RetNo]  DEFAULT ('') FOR [RetNo]
GO
ALTER TABLE [dbo].[PurchaseRet] ADD  CONSTRAINT [DF_PurchaseRet_PurchaseAutoNo]  DEFAULT (0) FOR [PurchaseCode]
GO
ALTER TABLE [dbo].[PurchaseRet] ADD  CONSTRAINT [DF_PurchaseRet_ItemAutoNo]  DEFAULT (0) FOR [ItemAutoNo]
GO
ALTER TABLE [dbo].[PurchaseRet] ADD  CONSTRAINT [DF_PurchaseRet_Qty]  DEFAULT (0) FOR [Qty]
GO
ALTER TABLE [dbo].[PurchaseRet] ADD  CONSTRAINT [DF_PurchaseRet_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[PurchaseRet] ADD  CONSTRAINT [DF_PurchaseRet_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[PurchaseRet] ADD  CONSTRAINT [DF_PurchaseRet_PCName]  DEFAULT ('''') FOR [PCName]
GO
ALTER TABLE [dbo].[PurchaseRet] ADD  CONSTRAINT [DF_PurchaseRet_UserCode]  DEFAULT ('') FOR [UserCode]
GO
ALTER TABLE [dbo].[PurchaseRet] ADD  CONSTRAINT [DF_PurchaseRet_ComId]  DEFAULT ('1') FOR [ComId]
GO
ALTER TABLE [dbo].[PurchaseRet] ADD  CONSTRAINT [DF_PurchaseRet_reason]  DEFAULT ('') FOR [reason]
GO
ALTER TABLE [dbo].[Quotation] ADD  CONSTRAINT [DF_Quotation_AutoNoFromMstrTbl]  DEFAULT (0) FOR [AutoNoFromMstrTbl]
GO
ALTER TABLE [dbo].[Quotation] ADD  CONSTRAINT [DF_Quotation_ItemName]  DEFAULT ('') FOR [ItemName]
GO
ALTER TABLE [dbo].[Quotation] ADD  CONSTRAINT [DF_Quotation_SlNo]  DEFAULT (0) FOR [SlNo]
GO
ALTER TABLE [dbo].[Quotation] ADD  CONSTRAINT [DF_Quotation_Qty]  DEFAULT (0) FOR [Qty]
GO
ALTER TABLE [dbo].[Quotation] ADD  CONSTRAINT [DF_Quotation_UnitPrice]  DEFAULT (0) FOR [UnitPrice]
GO
ALTER TABLE [dbo].[Quotation] ADD  CONSTRAINT [DF_Quotation_TotPrice]  DEFAULT (0) FOR [TotPrice]
GO
ALTER TABLE [dbo].[Quotation] ADD  CONSTRAINT [DF_Quotation_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[Quotation] ADD  CONSTRAINT [DF_Quotation_ComID]  DEFAULT ('') FOR [ComID]
GO
ALTER TABLE [dbo].[Quotation] ADD  CONSTRAINT [DF_Quotation_PcName]  DEFAULT ('') FOR [PcName]
GO
ALTER TABLE [dbo].[Quotation] ADD  CONSTRAINT [DF_Quotation_UserCode]  DEFAULT ('') FOR [UserCode]
GO
ALTER TABLE [dbo].[QuotationMstr] ADD  CONSTRAINT [DF_QuotationMstr_QutNo]  DEFAULT ('') FOR [QutNo]
GO
ALTER TABLE [dbo].[QuotationMstr] ADD  CONSTRAINT [DF_QuotationMstr_CusName]  DEFAULT ('') FOR [CusName]
GO
ALTER TABLE [dbo].[QuotationMstr] ADD  CONSTRAINT [DF_QuotationMstr_Deg]  DEFAULT ('') FOR [Designation]
GO
ALTER TABLE [dbo].[QuotationMstr] ADD  CONSTRAINT [DF_QuotationMstr_Addres]  DEFAULT ('') FOR [Address]
GO
ALTER TABLE [dbo].[QuotationMstr] ADD  CONSTRAINT [DF_QuotationMstr_PhoneNo]  DEFAULT ('') FOR [PhoneNo]
GO
ALTER TABLE [dbo].[QuotationMstr] ADD  CONSTRAINT [DF_QuotationMstr_Subject]  DEFAULT ('') FOR [Subject]
GO
ALTER TABLE [dbo].[QuotationMstr] ADD  CONSTRAINT [DF_QuotationMstr_ComID]  DEFAULT ('') FOR [ComID]
GO
ALTER TABLE [dbo].[QuotationMstr] ADD  CONSTRAINT [DF_QuotationMstr_PcName]  DEFAULT ('') FOR [PcName]
GO
ALTER TABLE [dbo].[QuotationMstr] ADD  CONSTRAINT [DF_QuotationMstr_UserCode]  DEFAULT ('') FOR [UserCode]
GO
ALTER TABLE [dbo].[QuotationMstr] ADD  CONSTRAINT [DF_QuotationMstr_PaymentTerms]  DEFAULT ('') FOR [PaymentTerms]
GO
ALTER TABLE [dbo].[QuotationMstr] ADD  CONSTRAINT [DF_QuotationMstr_SMC]  DEFAULT ('') FOR [SMC]
GO
ALTER TABLE [dbo].[RateEntry] ADD  CONSTRAINT [DF_RateEntry_CodeNo]  DEFAULT ('') FOR [SLNo]
GO
ALTER TABLE [dbo].[RateEntry] ADD  CONSTRAINT [DF_RateEntry_Stl]  DEFAULT ('') FOR [Stl]
GO
ALTER TABLE [dbo].[RateEntry] ADD  CONSTRAINT [DF_RateEntry_Sz]  DEFAULT ('') FOR [Sz]
GO
ALTER TABLE [dbo].[RateEntry] ADD  CONSTRAINT [DF_RateEntry_Rate]  DEFAULT (0) FOR [Rate]
GO
ALTER TABLE [dbo].[RateEntry] ADD  CONSTRAINT [DF_RateEntry_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[RateEntry] ADD  CONSTRAINT [DF_RateEntry_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[RateEntry] ADD  CONSTRAINT [DF_RateEntry_UserCode]  DEFAULT ('') FOR [UserCode]
GO
ALTER TABLE [dbo].[RateEntry] ADD  CONSTRAINT [DF_RateEntry_ComId]  DEFAULT ('1') FOR [ComId]
GO
ALTER TABLE [dbo].[RateEntry] ADD  CONSTRAINT [DF_RateEntry_PCName]  DEFAULT ('') FOR [PCName]
GO
ALTER TABLE [dbo].[RateEntry] ADD  CONSTRAINT [DF__rateentry__Body__56F3D4A3]  DEFAULT ('') FOR [Body]
GO
ALTER TABLE [dbo].[RateEntry] ADD  CONSTRAINT [DF__rateentry__Sec__6AFACD50]  DEFAULT ('') FOR [Sec]
GO
ALTER TABLE [dbo].[Requisition] ADD  CONSTRAINT [DF_Requisition_PrjCode]  DEFAULT (0) FOR [PrjAutoNo]
GO
ALTER TABLE [dbo].[Requisition] ADD  CONSTRAINT [DF_Requisition_SlNo]  DEFAULT (0) FOR [SlNo]
GO
ALTER TABLE [dbo].[Requisition] ADD  CONSTRAINT [DF_Requisition_ItemAutoNo]  DEFAULT (0) FOR [ItemAutoNo]
GO
ALTER TABLE [dbo].[Requisition] ADD  CONSTRAINT [DF_Requisition_Qty]  DEFAULT (0) FOR [Qty]
GO
ALTER TABLE [dbo].[Requisition] ADD  CONSTRAINT [DF_Requisition_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[Requisition] ADD  CONSTRAINT [DF_Requisition_ComID]  DEFAULT ('') FOR [ComID]
GO
ALTER TABLE [dbo].[ResultSheet] ADD  CONSTRAINT [DF_ResultSheet_Sid]  DEFAULT ('') FOR [SID]
GO
ALTER TABLE [dbo].[ResultSheet] ADD  CONSTRAINT [DF_ResultSheet_ClassId]  DEFAULT ('') FOR [ClassCode]
GO
ALTER TABLE [dbo].[ResultSheet] ADD  CONSTRAINT [DF_ResultSheet_ExamName]  DEFAULT ('') FOR [ExamName]
GO
ALTER TABLE [dbo].[ResultSheet] ADD  CONSTRAINT [DF_ResultSheet_Gpa]  DEFAULT (0) FOR [Gpa]
GO
ALTER TABLE [dbo].[ResultSheet] ADD  CONSTRAINT [DF_ResultSheet_ComId]  DEFAULT ('') FOR [ComId]
GO
ALTER TABLE [dbo].[ResultSheet] ADD  CONSTRAINT [DF__ResultShe__ForMo__63F9955D]  DEFAULT ('') FOR [ForMonth]
GO
ALTER TABLE [dbo].[ResultSheet] ADD  CONSTRAINT [DF__ResultShe__ForYe__64EDB996]  DEFAULT ('') FOR [ForYear]
GO
ALTER TABLE [dbo].[ResultSheet] ADD  CONSTRAINT [DF__ResultSheet__BM__65E1DDCF]  DEFAULT (0) FOR [BM]
GO
ALTER TABLE [dbo].[ResultSheet] ADD  CONSTRAINT [DF__ResultSheet__SM__66D60208]  DEFAULT (0) FOR [SM]
GO
ALTER TABLE [dbo].[ResultSheet] ADD  CONSTRAINT [DF__ResultSheet__CT__67CA2641]  DEFAULT (0) FOR [CT]
GO
ALTER TABLE [dbo].[ResultSheet] ADD  CONSTRAINT [DF__ResultSheet__Sec__5FF3FA4F]  DEFAULT ('') FOR [Sec]
GO
ALTER TABLE [dbo].[ResultSheet] ADD  CONSTRAINT [DF__ResultShe__SubjC__60E81E88]  DEFAULT ('') FOR [SubjCode]
GO
ALTER TABLE [dbo].[ResultSheet] ADD  CONSTRAINT [DF__ResultShe__Grade__61DC42C1]  DEFAULT ('') FOR [Grade]
GO
ALTER TABLE [dbo].[ResultSheet] ADD  CONSTRAINT [DF__ResultShe__TotSu__702A6218]  DEFAULT (0) FOR [TotSubject]
GO
ALTER TABLE [dbo].[ResultSheet] ADD  CONSTRAINT [DF__ResultShe__TotGp__711E8651]  DEFAULT (0) FOR [TotGpa]
GO
ALTER TABLE [dbo].[ResultSheet] ADD  CONSTRAINT [DF__ResultShe__ResGp__7212AA8A]  DEFAULT (0) FOR [ResGpa]
GO
ALTER TABLE [dbo].[ResultSheet] ADD  CONSTRAINT [DF__ResultShe__RollN__7306CEC3]  DEFAULT (0) FOR [RollNo]
GO
ALTER TABLE [dbo].[SalBeforeProcess] ADD  CONSTRAINT [DF_SalBeforeProcess_EmpId]  DEFAULT ('') FOR [EmpId]
GO
ALTER TABLE [dbo].[SalBeforeProcess] ADD  CONSTRAINT [DF_SalBeforeProcess_ForMonth]  DEFAULT ('') FOR [ForMonth]
GO
ALTER TABLE [dbo].[SalBeforeProcess] ADD  CONSTRAINT [DF_SalBeforeProcess_ForYear]  DEFAULT ('') FOR [ForYear]
GO
ALTER TABLE [dbo].[SalBeforeProcess] ADD  CONSTRAINT [DF_SalBeforeProcess_Amount]  DEFAULT (0) FOR [Amount]
GO
ALTER TABLE [dbo].[Sale] ADD  CONSTRAINT [DF_Sale_SLNo]  DEFAULT (0) FOR [SLNo]
GO
ALTER TABLE [dbo].[Sale] ADD  CONSTRAINT [DF_Sale_Qty]  DEFAULT (0) FOR [Qty]
GO
ALTER TABLE [dbo].[Sale] ADD  CONSTRAINT [DF_Sale_UnitPrice]  DEFAULT (0) FOR [UnitPrice]
GO
ALTER TABLE [dbo].[Sale] ADD  CONSTRAINT [DF_Sale_TotPrice]  DEFAULT (0) FOR [TotPrice]
GO
ALTER TABLE [dbo].[Sale] ADD  CONSTRAINT [DF_Sale_PurchaseCode]  DEFAULT ('') FOR [PurchaseCode]
GO
ALTER TABLE [dbo].[Sale] ADD  CONSTRAINT [DF_Sale_PcName]  DEFAULT ('') FOR [PcName]
GO
ALTER TABLE [dbo].[Sale] ADD  CONSTRAINT [DF_Sale_CusName]  DEFAULT ('') FOR [CusName]
GO
ALTER TABLE [dbo].[Sale] ADD  CONSTRAINT [DF_Sale_ComId]  DEFAULT ('1') FOR [ComId]
GO
ALTER TABLE [dbo].[Sale] ADD  CONSTRAINT [DF_Sale_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[Sale] ADD  CONSTRAINT [DF_Sale_ItemAutoNo]  DEFAULT (0) FOR [ItemAutoNo]
GO
ALTER TABLE [dbo].[Sale] ADD  CONSTRAINT [DF_Sale_Barcode]  DEFAULT ('') FOR [Barcode]
GO
ALTER TABLE [dbo].[Sale] ADD  CONSTRAINT [DF_Sale_AutoNoFromSaleMstr]  DEFAULT (1) FOR [AutoNoFromSaleMstr]
GO
ALTER TABLE [dbo].[Sale] ADD  CONSTRAINT [DF_Sale_UserCode]  DEFAULT ('') FOR [UserCode]
GO
ALTER TABLE [dbo].[Sale] ADD  CONSTRAINT [DF__sale__Rmk__70CA7DB7]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[Sale] ADD  CONSTRAINT [DF__Sale__Type__00A02776]  DEFAULT ('') FOR [Type]
GO
ALTER TABLE [dbo].[Sale] ADD  CONSTRAINT [DF__sale__Roll__560ACF2C]  DEFAULT (0) FOR [Roll]
GO
ALTER TABLE [dbo].[Sale] ADD  CONSTRAINT [DF__sale__DiaGz__56FEF365]  DEFAULT (0) FOR [DiaGz]
GO
ALTER TABLE [dbo].[Sale] ADD  CONSTRAINT [DF__sale__ConvRate__43ABF605]  DEFAULT (0) FOR [ConvRate]
GO
ALTER TABLE [dbo].[Sale] ADD  CONSTRAINT [DF__sale__ItemCode__2F725533]  DEFAULT ('') FOR [ItemCode]
GO
ALTER TABLE [dbo].[Sale] ADD  CONSTRAINT [DF__sale__Hide__7FEBC895]  DEFAULT (0) FOR [Hide]
GO
ALTER TABLE [dbo].[Sale] ADD  CONSTRAINT [DF__Sale__PayAble__4B180DA3]  DEFAULT (0) FOR [PayAble]
GO
ALTER TABLE [dbo].[Sale] ADD  CONSTRAINT [DF__Sale__TotDis__4C0C31DC]  DEFAULT (0) FOR [TotDis]
GO
ALTER TABLE [dbo].[Sale] ADD  CONSTRAINT [DF__Sale__SaleType__330B79E8]  DEFAULT ('') FOR [SaleType]
GO
ALTER TABLE [dbo].[Sale] ADD  CONSTRAINT [DF__Sale__PrSlNo__3C94E422]  DEFAULT ('') FOR [PrSlNo]
GO
ALTER TABLE [dbo].[Sale] ADD  CONSTRAINT [DF__sale__Warranty__556091EC]  DEFAULT (0) FOR [Warranty]
GO
ALTER TABLE [dbo].[Sale] ADD  CONSTRAINT [DF__Sale__WarType__5654B625]  DEFAULT ('Days') FOR [WarType]
GO
ALTER TABLE [dbo].[Sale] ADD  CONSTRAINT [DF__Sale__LastPurPri__71FCD09A]  DEFAULT (0) FOR [LastPurPrice]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF_SaleMstr_InvoiceNo]  DEFAULT (0) FOR [InvoiceNo]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF_SaleMstr_Total]  DEFAULT (0) FOR [Total]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF_SaleMstr_Due]  DEFAULT (0) FOR [Due]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF_SaleMstr_Discount]  DEFAULT (0) FOR [Discount]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF_SaleMstr_Payable]  DEFAULT (0) FOR [Payable]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF_SaleMstr_Refund]  DEFAULT (0) FOR [Refund]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF_SaleMstr_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF_SaleMstr_Vat]  DEFAULT (0) FOR [Vat]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF_SaleMstr_PartyCode]  DEFAULT (0) FOR [PartyAuto]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF_SaleMstr_PCNAME]  DEFAULT ('') FOR [PCNAME]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF_SaleMstr_Paymode]  DEFAULT ('') FOR [Paymode]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF_SaleMstr_CardNo]  DEFAULT (0) FOR [CardNo]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF_SaleMstr_BankName]  DEFAULT ('') FOR [BankName]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF_SaleMstr_Paid]  DEFAULT (0) FOR [Paid]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF__salemstr__TotVat__1CA7377D]  DEFAULT (0) FOR [TotVat]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF__salemstr__DisPer__1D9B5BB6]  DEFAULT (0) FOR [DisPer]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF_SaleMstr_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF_SaleMstr_UserName]  DEFAULT ('') FOR [UserCode]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF_SaleMstr_CashAmt]  DEFAULT (0) FOR [CashAmt]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF_SaleMstr_CardAmt]  DEFAULT (0) FOR [CardAmt]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF_SaleMstr_SaleType]  DEFAULT ('') FOR [SaleType]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF_SaleMstr_InstAmt1]  DEFAULT (0) FOR [InstAmt1]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF_SaleMstr_InstAmt2]  DEFAULT (0) FOR [InstAmt2]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF_SaleMstr_InstAmt3]  DEFAULT (0) FOR [InstAmt3]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF_SaleMstr_IntPerc]  DEFAULT (0) FOR [IntPerc]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF__SALEMSTR__INTaMT__6B4FD30B]  DEFAULT (0) FOR [INTaMT]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF_SaleMstr_PrjCode]  DEFAULT ('0') FOR [PrjCode]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF__Salemstr__Type__052FD269]  DEFAULT ('') FOR [Type]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF_SaleMstr_PrjAutoNo]  DEFAULT (0) FOR [PrjAutoNo]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF__SaleMstr__MenoNo__33B5B728]  DEFAULT ('') FOR [MenoNo]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF__SaleMstr__AutoRm__34A9DB61]  DEFAULT ('') FOR [AutoRmk]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF_SaleMstr_Footer]  DEFAULT ('') FOR [Footer]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF_SaleMstr_Header]  DEFAULT ('') FOR [Header]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF__saleMstr__ConvRa__42B7D1CC]  DEFAULT (0) FOR [ConvRate]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF__saleMstr__CrHead__7AC982CA]  DEFAULT ('') FOR [CrHeadId]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF__SaleMstr__CusNam__492FC531]  DEFAULT ('') FOR [CusName]
GO
ALTER TABLE [dbo].[SaleMstr] ADD  CONSTRAINT [DF__SaleMstr__CusMob__4A23E96A]  DEFAULT ('') FOR [CusMobile]
GO
ALTER TABLE [dbo].[SalesOrder] ADD  CONSTRAINT [DF_SalesOrders_AutoNoFromMstrTbl]  DEFAULT (0) FOR [AutoNoFromMstrTbl]
GO
ALTER TABLE [dbo].[SalesOrder] ADD  CONSTRAINT [DF_SalesOrder_SlNo]  DEFAULT (0) FOR [SlNo]
GO
ALTER TABLE [dbo].[SalesOrder] ADD  CONSTRAINT [DF_SalesOrders_ItemAutono]  DEFAULT (0) FOR [ItemAutoNo]
GO
ALTER TABLE [dbo].[SalesOrder] ADD  CONSTRAINT [DF_SalesOrders_Qty]  DEFAULT (0) FOR [Qty]
GO
ALTER TABLE [dbo].[SalesOrder] ADD  CONSTRAINT [DF_SalesOrders_UnitPrice]  DEFAULT (0) FOR [UnitPrice]
GO
ALTER TABLE [dbo].[SalesOrder] ADD  CONSTRAINT [DF_SalesOrder_TotPrice]  DEFAULT (0) FOR [TotPrice]
GO
ALTER TABLE [dbo].[SalesOrder] ADD  CONSTRAINT [DF_SalesOrders_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[SalesOrder] ADD  CONSTRAINT [DF_SalesOrders_ComId]  DEFAULT ('') FOR [ComId]
GO
ALTER TABLE [dbo].[SalesOrder] ADD  CONSTRAINT [DF_SalesOrders_UserCode]  DEFAULT ('') FOR [UserCode]
GO
ALTER TABLE [dbo].[SalesOrder] ADD  CONSTRAINT [DF_SalesOrders_PcName]  DEFAULT ('') FOR [PcName]
GO
ALTER TABLE [dbo].[SalesOrderMstr] ADD  CONSTRAINT [DF_SalesOrderMstr_OrderNo]  DEFAULT ('') FOR [OrderNo]
GO
ALTER TABLE [dbo].[SalesOrderMstr] ADD  CONSTRAINT [DF_SalesOrderMstr_CusName]  DEFAULT ('') FOR [CusName]
GO
ALTER TABLE [dbo].[SalesOrderMstr] ADD  CONSTRAINT [DF_SalesOrderMstr_Address]  DEFAULT ('') FOR [Address]
GO
ALTER TABLE [dbo].[SalesOrderMstr] ADD  CONSTRAINT [DF_SalesOrderMstr_Phone]  DEFAULT ('') FOR [PhoneNo]
GO
ALTER TABLE [dbo].[SalesOrderMstr] ADD  CONSTRAINT [DF_SalesOrderMstr_Email]  DEFAULT ('') FOR [Email]
GO
ALTER TABLE [dbo].[SalesOrderMstr] ADD  CONSTRAINT [DF_SalesOrderMstr_ComID]  DEFAULT ('') FOR [ComID]
GO
ALTER TABLE [dbo].[SalesOrderMstr] ADD  CONSTRAINT [DF_SalesOrderMstr_UserCode]  DEFAULT ('') FOR [UserCode]
GO
ALTER TABLE [dbo].[SalesOrderMstr] ADD  CONSTRAINT [DF_SalesOrderMstr_PcName]  DEFAULT ('') FOR [PcName]
GO
ALTER TABLE [dbo].[SalStyle] ADD  CONSTRAINT [DF__SalStyle__Style__1BBECB93]  DEFAULT ('') FOR [Style]
GO
ALTER TABLE [dbo].[SalStyle] ADD  CONSTRAINT [DF__SalStyle__Gross__1CB2EFCC]  DEFAULT (0) FOR [Gross]
GO
ALTER TABLE [dbo].[SalStyle] ADD  CONSTRAINT [DF__SalStyle__Basic__1DA71405]  DEFAULT (0) FOR [Basic]
GO
ALTER TABLE [dbo].[SalStyle] ADD  CONSTRAINT [DF__SalStyle__HRent__1E9B383E]  DEFAULT (0) FOR [HRent]
GO
ALTER TABLE [dbo].[SalStyle] ADD  CONSTRAINT [DF__SalStyle__Medica__1F8F5C77]  DEFAULT (0) FOR [Medical]
GO
ALTER TABLE [dbo].[SalStyle] ADD  CONSTRAINT [DF__SalStyle__Conv__208380B0]  DEFAULT (0) FOR [Conv]
GO
ALTER TABLE [dbo].[SalStyle] ADD  CONSTRAINT [DF__SalStyle__Food__2177A4E9]  DEFAULT (0) FOR [Food]
GO
ALTER TABLE [dbo].[SalStyle] ADD  CONSTRAINT [DF__SalStyle__Others__226BC922]  DEFAULT (0) FOR [Others]
GO
ALTER TABLE [dbo].[Scan] ADD  CONSTRAINT [DF_Scan_EmpAutoNo]  DEFAULT (1) FOR [EmpAutoNo]
GO
ALTER TABLE [dbo].[Scan] ADD  CONSTRAINT [DF_Scan_EmpId]  DEFAULT ('') FOR [EmpId]
GO
ALTER TABLE [dbo].[SectionTbl] ADD  CONSTRAINT [DF_SectionTbl_CodeNo]  DEFAULT (0) FOR [CodeNo]
GO
ALTER TABLE [dbo].[SectionTbl] ADD  CONSTRAINT [DF_SectionTbl_Name]  DEFAULT ('') FOR [Name]
GO
ALTER TABLE [dbo].[SectionTbl] ADD  CONSTRAINT [DF_SectionTbl_BName]  DEFAULT ('') FOR [BName]
GO
ALTER TABLE [dbo].[SectionTbl] ADD  CONSTRAINT [DF_SectionTbl_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[SectionTbl] ADD  CONSTRAINT [DF_SectionTbl_PcName]  DEFAULT ('') FOR [PcName]
GO
ALTER TABLE [dbo].[SectionTbl] ADD  CONSTRAINT [DF_SectionTbl_UserCode]  DEFAULT (0) FOR [UserCode]
GO
ALTER TABLE [dbo].[SectionTbl] ADD  CONSTRAINT [DF_SectionTbl_ComId]  DEFAULT ('1') FOR [ComId]
GO
ALTER TABLE [dbo].[SectionTbl] ADD  CONSTRAINT [DF_SectionTbl_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[SectionTbl] ADD  CONSTRAINT [DF_SectionTbl_ShortName]  DEFAULT ('') FOR [ShortName]
GO
ALTER TABLE [dbo].[Security] ADD  CONSTRAINT [DF_Security_UserCode]  DEFAULT (0) FOR [UserCode]
GO
ALTER TABLE [dbo].[Security] ADD  CONSTRAINT [DF_Security_SCREEN]  DEFAULT ('') FOR [SCREEN]
GO
ALTER TABLE [dbo].[Security] ADD  CONSTRAINT [DF_Security_s]  DEFAULT (0) FOR [s]
GO
ALTER TABLE [dbo].[Security] ADD  CONSTRAINT [DF_Security_d]  DEFAULT (0) FOR [d]
GO
ALTER TABLE [dbo].[Security] ADD  CONSTRAINT [DF_Security_v]  DEFAULT (0) FOR [v]
GO
ALTER TABLE [dbo].[Security] ADD  CONSTRAINT [DF_Security_e]  DEFAULT (0) FOR [e]
GO
ALTER TABLE [dbo].[Security] ADD  CONSTRAINT [DF_Security_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[Security] ADD  CONSTRAINT [DF_Security_UID]  DEFAULT ('') FOR [UID]
GO
ALTER TABLE [dbo].[Security] ADD  CONSTRAINT [DF__Security__Sw__359DFF9A]  DEFAULT (0) FOR [Sw]
GO
ALTER TABLE [dbo].[Security] ADD  CONSTRAINT [DF__Security__Kn__369223D3]  DEFAULT (0) FOR [Kn]
GO
ALTER TABLE [dbo].[Security] ADD  CONSTRAINT [DF__Security__Hrm__3786480C]  DEFAULT (0) FOR [Hrm]
GO
ALTER TABLE [dbo].[Setting] ADD  CONSTRAINT [DF_Setting_SalaryStyle]  DEFAULT ('') FOR [SalaryStyle]
GO
ALTER TABLE [dbo].[Setting] ADD  CONSTRAINT [DF_Setting_PhotoPath]  DEFAULT ('') FOR [PhotoPath]
GO
ALTER TABLE [dbo].[Setting] ADD  CONSTRAINT [DF_Setting_DollarRate]  DEFAULT (0) FOR [DollarRate]
GO
ALTER TABLE [dbo].[Setting] ADD  CONSTRAINT [DF_Setting_BackImage]  DEFAULT (0) FOR [BackImage]
GO
ALTER TABLE [dbo].[Setting] ADD  CONSTRAINT [DF_Setting_PcName]  DEFAULT ('') FOR [PcName]
GO
ALTER TABLE [dbo].[Setting] ADD  CONSTRAINT [DF_Setting_UserCode]  DEFAULT ('') FOR [UserCode]
GO
ALTER TABLE [dbo].[Setting] ADD  CONSTRAINT [DF_Setting_ComID]  DEFAULT ('') FOR [ComID]
GO
ALTER TABLE [dbo].[Setting] ADD  CONSTRAINT [DF_Setting_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[Setting] ADD  CONSTRAINT [DF_Setting_TextFilePath]  DEFAULT ('') FOR [TextFilePath]
GO
ALTER TABLE [dbo].[Setting] ADD  CONSTRAINT [DF__setting__Topp__76D82AFE]  DEFAULT (0) FOR [Topp]
GO
ALTER TABLE [dbo].[Setting] ADD  CONSTRAINT [DF__setting__Heightt__77CC4F37]  DEFAULT (8000) FOR [Heightt]
GO
ALTER TABLE [dbo].[Setting] ADD  CONSTRAINT [DF__setting__Leftt__78C07370]  DEFAULT (0) FOR [Leftt]
GO
ALTER TABLE [dbo].[Setting] ADD  CONSTRAINT [DF__setting__Widthh__79B497A9]  DEFAULT (14000) FOR [Widthh]
GO
ALTER TABLE [dbo].[SettingSingle] ADD  CONSTRAINT [DF_SettingSingle_VatPerc]  DEFAULT (0) FOR [VatPerc]
GO
ALTER TABLE [dbo].[SettingSingle] ADD  CONSTRAINT [DF_SettingSingle_CommonItem]  DEFAULT (0) FOR [CommonItem]
GO
ALTER TABLE [dbo].[SettingSingle] ADD  CONSTRAINT [DF_SettingSingle_CommonParty]  DEFAULT (0) FOR [CommonParty]
GO
ALTER TABLE [dbo].[SettingSingle] ADD  CONSTRAINT [DF_SettingSingle_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[SettingSingle] ADD  CONSTRAINT [DF_SettingSingle_PhotoPath]  DEFAULT ('') FOR [PhotoPath]
GO
ALTER TABLE [dbo].[SettingSingle] ADD  CONSTRAINT [DF_SettingSingle_VAT]  DEFAULT (0) FOR [VAT]
GO
ALTER TABLE [dbo].[SettingSingle] ADD  CONSTRAINT [DF_SettingSingle_RMSPath]  DEFAULT ('') FOR [RMSPath]
GO
ALTER TABLE [dbo].[SettingSingle] ADD  CONSTRAINT [DF_SettingSingle_HandKey]  DEFAULT (0) FOR [HandKey]
GO
ALTER TABLE [dbo].[SettingSingle] ADD  CONSTRAINT [DF_SettingSingle_LockDate]  DEFAULT (getdate()) FOR [LockDate]
GO
ALTER TABLE [dbo].[SettingSingle] ADD  CONSTRAINT [DF_SettingSingle_InvoiceBig]  DEFAULT (0) FOR [InvoiceBig]
GO
ALTER TABLE [dbo].[SettingSingle] ADD  CONSTRAINT [DF_SettingSingle_AutoGenEmpId]  DEFAULT (0) FOR [AutoGenEmpId]
GO
ALTER TABLE [dbo].[SettingSingle] ADD  CONSTRAINT [DF__settingSi__Salar__1200572F]  DEFAULT ('BGMEA') FOR [SalaryStyle]
GO
ALTER TABLE [dbo].[SettingSingle] ADD  CONSTRAINT [DF_SettingSingle_ComID]  DEFAULT ('1') FOR [ComID]
GO
ALTER TABLE [dbo].[SettingSingle] ADD  CONSTRAINT [DF__settingSi__SHOWP__74EFE28C]  DEFAULT ('') FOR [SHOWPWD]
GO
ALTER TABLE [dbo].[SettingSingle] ADD  CONSTRAINT [DF__settingSi__HIDEP__75E406C5]  DEFAULT ('') FOR [HIDEPWD]
GO
ALTER TABLE [dbo].[SettingSingle] ADD  CONSTRAINT [DF_SettingSingle_PickSalePriceFromPur]  DEFAULT (0) FOR [PickSalePriceFromPur]
GO
ALTER TABLE [dbo].[SettingSingle] ADD  CONSTRAINT [DF_SettingSingle_envFrom]  DEFAULT ('') FOR [envFrom]
GO
ALTER TABLE [dbo].[SettingSingle] ADD  CONSTRAINT [DF_SettingSingle_envTo]  DEFAULT ('') FOR [envTo]
GO
ALTER TABLE [dbo].[SettingSingle] ADD  CONSTRAINT [DF_SettingSingle_dontPrintInvoice]  DEFAULT (0) FOR [dontPrintInvoice]
GO
ALTER TABLE [dbo].[SettingSingle] ADD  CONSTRAINT [DF__settingSi__ChPro__4D02B81A]  DEFAULT (1) FOR [ChProPrice]
GO
ALTER TABLE [dbo].[SettingSingle] ADD  CONSTRAINT [DF__SettingSi__BtnDe__33FF9E21]  DEFAULT (0) FOR [BtnDelInvoice]
GO
ALTER TABLE [dbo].[SettingSingle] ADD  CONSTRAINT [DF__SettingSi__SaleF__34F3C25A]  DEFAULT (0) FOR [SaleFormLocationX]
GO
ALTER TABLE [dbo].[SettingSingle] ADD  CONSTRAINT [DF__SettingSi__SaleF__35E7E693]  DEFAULT (0) FOR [SaleFormLocationY]
GO
ALTER TABLE [dbo].[SettingSingle] ADD  CONSTRAINT [DF__SettingSi__PayMo__36DC0ACC]  DEFAULT (0) FOR [PayMode]
GO
ALTER TABLE [dbo].[SettingSingle] ADD  CONSTRAINT [DF__SettingSi__Nuhas__38C4533E]  DEFAULT (0) FOR [NuhashGL]
GO
ALTER TABLE [dbo].[SettingSingle] ADD  DEFAULT ('') FOR [MobiileNo]
GO
ALTER TABLE [dbo].[SettingSingle] ADD  DEFAULT ('') FOR [MobileNo]
GO
ALTER TABLE [dbo].[ShiftSet] ADD  CONSTRAINT [DF_ShiftSet_GroupID]  DEFAULT ('') FOR [GroupID]
GO
ALTER TABLE [dbo].[ShiftSet] ADD  CONSTRAINT [DF_ShiftSet_ForMonth]  DEFAULT ('') FOR [ForMonth]
GO
ALTER TABLE [dbo].[ShiftSet] ADD  CONSTRAINT [DF_ShiftSet_ForYear]  DEFAULT ('') FOR [ForYear]
GO
ALTER TABLE [dbo].[ShiftSet] ADD  CONSTRAINT [DF_ShiftSet_PCNAME]  DEFAULT ('') FOR [PCNAME]
GO
ALTER TABLE [dbo].[ShiftSet] ADD  CONSTRAINT [DF_ShiftSet_USERCODE]  DEFAULT (0) FOR [USERCODE]
GO
ALTER TABLE [dbo].[ShiftSet] ADD  CONSTRAINT [DF_ShiftSet_ENTRYTIME]  DEFAULT (getdate()) FOR [ENTRYTIME]
GO
ALTER TABLE [dbo].[ShiftSet] ADD  CONSTRAINT [DF_ShiftSet_ComID]  DEFAULT ('1') FOR [ComID]
GO
ALTER TABLE [dbo].[SMSSent] ADD  CONSTRAINT [DF_SMSSent_MobileNo]  DEFAULT ('') FOR [MobileNo]
GO
ALTER TABLE [dbo].[SMSSent] ADD  CONSTRAINT [DF_SMSSent_MsgBody]  DEFAULT ('') FOR [MsgBody]
GO
ALTER TABLE [dbo].[SMSSent] ADD  CONSTRAINT [DF_SMSSent_ContactName]  DEFAULT ('') FOR [ContactName]
GO
ALTER TABLE [dbo].[SMSSent] ADD  CONSTRAINT [DF_SMSSent_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[SMSSent] ADD  CONSTRAINT [DF_SMSSent_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[Stock] ADD  CONSTRAINT [DF_Stock_ItemCode]  DEFAULT ('') FOR [ItemCode]
GO
ALTER TABLE [dbo].[Stock] ADD  CONSTRAINT [DF_Stock_ItemName]  DEFAULT ('') FOR [ItemName]
GO
ALTER TABLE [dbo].[Stock] ADD  CONSTRAINT [DF_Stock_ItemType]  DEFAULT ('') FOR [ItemType]
GO
ALTER TABLE [dbo].[Stock] ADD  CONSTRAINT [DF_Stock_ItemSize]  DEFAULT ('') FOR [ItemSize]
GO
ALTER TABLE [dbo].[Stock] ADD  CONSTRAINT [DF_Stock_INQty]  DEFAULT (0) FOR [INQty]
GO
ALTER TABLE [dbo].[Stock] ADD  CONSTRAINT [DF_Stock_OutQty]  DEFAULT (0) FOR [OutQty]
GO
ALTER TABLE [dbo].[Stock] ADD  CONSTRAINT [DF_Stock_DQty]  DEFAULT (0) FOR [DQty]
GO
ALTER TABLE [dbo].[StockRpt] ADD  CONSTRAINT [DF_StockRpt_ItemCode]  DEFAULT ('') FOR [ItemCode]
GO
ALTER TABLE [dbo].[StockRpt] ADD  CONSTRAINT [DF_StockRpt_ComID]  DEFAULT ('') FOR [ComID]
GO
ALTER TABLE [dbo].[StockRpt] ADD  CONSTRAINT [DF_StockRpt_OPBal]  DEFAULT (0) FOR [OPBal]
GO
ALTER TABLE [dbo].[StockRpt] ADD  CONSTRAINT [DF_StockRpt_InQty]  DEFAULT (0) FOR [InQty]
GO
ALTER TABLE [dbo].[StockRpt] ADD  CONSTRAINT [DF_StockRpt_OutQty]  DEFAULT (0) FOR [OutQty]
GO
ALTER TABLE [dbo].[StockRpt] ADD  CONSTRAINT [DF_StockRpt_DamQty]  DEFAULT (0) FOR [DamQty]
GO
ALTER TABLE [dbo].[StockRpt] ADD  CONSTRAINT [DF_StockRpt_RetQty]  DEFAULT (0) FOR [RetQty]
GO
ALTER TABLE [dbo].[StockRpt] ADD  CONSTRAINT [DF_StockRpt_InHandQty]  DEFAULT (0) FOR [InHandQty]
GO
ALTER TABLE [dbo].[StockRpt] ADD  CONSTRAINT [DF_StockRpt_LatestUnitPrice]  DEFAULT (0) FOR [OpeningUnitPrice]
GO
ALTER TABLE [dbo].[StockRpt] ADD  CONSTRAINT [DF_StockRpt_TotalPrice]  DEFAULT (0) FOR [OpeningTotalPrice]
GO
ALTER TABLE [dbo].[StockRpt] ADD  CONSTRAINT [DF_StockRpt_UserCode]  DEFAULT ('') FOR [UserCode]
GO
ALTER TABLE [dbo].[StockRpt] ADD  CONSTRAINT [DF_StockRpt_ItemAutoNo]  DEFAULT (0) FOR [ItemAutoNo]
GO
ALTER TABLE [dbo].[StockRpt] ADD  CONSTRAINT [DF_StockRpt_ProfitWholeSale]  DEFAULT (0) FOR [ProfitWholeSale]
GO
ALTER TABLE [dbo].[StockRpt] ADD  CONSTRAINT [DF_StockRpt_ProfitRetailSale]  DEFAULT (0) FOR [ProfitRetailSale]
GO
ALTER TABLE [dbo].[StockRpt] ADD  CONSTRAINT [DF_StockRpt_PCName]  DEFAULT ('') FOR [PCName]
GO
ALTER TABLE [dbo].[StockRpt] ADD  CONSTRAINT [DF_StockRpt_UnitPrice]  DEFAULT (0) FOR [ClosingUnitPrice]
GO
ALTER TABLE [dbo].[StockRpt] ADD  CONSTRAINT [DF_StockRpt_OPBalTotalPrice]  DEFAULT (0) FOR [ClosingTotalPrice]
GO
ALTER TABLE [dbo].[StockRpt] ADD  CONSTRAINT [DF__stockrpt__totalP__498FB7E4]  DEFAULT (0) FOR [totalPrice]
GO
ALTER TABLE [dbo].[StockRpt] ADD  CONSTRAINT [DF__stockRpt__OpTotP__097532CF]  DEFAULT (0) FOR [OpTotPurQty]
GO
ALTER TABLE [dbo].[StockRpt] ADD  CONSTRAINT [DF__stockRpt__ClTotP__0A695708]  DEFAULT (0) FOR [ClTotPurQty]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_Name]  DEFAULT ('') FOR [Name]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_FatherName]  DEFAULT ('') FOR [FatherName]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_MotherName]  DEFAULT ('') FOR [MotherName]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_GuardianName]  DEFAULT ('') FOR [GuardianName]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_GuardianRelation]  DEFAULT ('') FOR [GuardianRelation]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_Sex]  DEFAULT ('') FOR [Sex]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_PeAddress]  DEFAULT ('') FOR [PeAddress]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_PrAddress]  DEFAULT ('') FOR [PrAddress]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_Phone]  DEFAULT ('') FOR [Phone]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_Blood]  DEFAULT ('') FOR [Blood]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_Relegion]  DEFAULT ('') FOR [Relegion]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_NID]  DEFAULT ('') FOR [NID]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_Reference1]  DEFAULT ('') FOR [Reference1]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_Reference2]  DEFAULT ('') FOR [Reference2]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_CardNo]  DEFAULT ('') FOR [CardNo]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_Active]  DEFAULT (0) FOR [Active]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_Transport]  DEFAULT (0) FOR [Transport]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_PcName]  DEFAULT ('') FOR [PcName]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_UserCode]  DEFAULT (0) FOR [UserCode]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[Swipe] ADD  CONSTRAINT [DF_Swipe_Empid]  DEFAULT ('') FOR [Empid]
GO
ALTER TABLE [dbo].[TB] ADD  CONSTRAINT [DF__TB__COMID__7F029154]  DEFAULT ('') FOR [COMID]
GO
ALTER TABLE [dbo].[TB] ADD  CONSTRAINT [DF__TB__PCNAME__7FF6B58D]  DEFAULT ('') FOR [PCNAME]
GO
ALTER TABLE [dbo].[TBCur] ADD  CONSTRAINT [DF__TBCur__COMID__7F029154]  DEFAULT ('') FOR [COMID]
GO
ALTER TABLE [dbo].[TBCur] ADD  CONSTRAINT [DF__TBCur__PCNAME__7FF6B58D]  DEFAULT ('') FOR [PCNAME]
GO
ALTER TABLE [dbo].[TBOpBal] ADD  CONSTRAINT [DF__TBOPBal__COMID__7F029154]  DEFAULT ('') FOR [COMID]
GO
ALTER TABLE [dbo].[TBOpBal] ADD  CONSTRAINT [DF__TBOPBal__PCNAME__7FF6B58D]  DEFAULT ('') FOR [PCNAME]
GO
ALTER TABLE [dbo].[TeacherInfo] ADD  CONSTRAINT [DF_TeacherInfo_TID]  DEFAULT ('') FOR [TID]
GO
ALTER TABLE [dbo].[TeacherInfo] ADD  CONSTRAINT [DF_TeacherInfo_TName]  DEFAULT ('') FOR [TName]
GO
ALTER TABLE [dbo].[TeacherInfo] ADD  CONSTRAINT [DF_TeacherInfo_FName]  DEFAULT ('') FOR [FName]
GO
ALTER TABLE [dbo].[TeacherInfo] ADD  CONSTRAINT [DF_TeacherInfo_MName]  DEFAULT ('') FOR [MName]
GO
ALTER TABLE [dbo].[TeacherInfo] ADD  CONSTRAINT [DF_TeacherInfo_PresentAddress]  DEFAULT ('') FOR [PresentAddress]
GO
ALTER TABLE [dbo].[TeacherInfo] ADD  CONSTRAINT [DF_TeacherInfo_ParmanentAddress]  DEFAULT ('') FOR [ParmanentAddress]
GO
ALTER TABLE [dbo].[TeacherInfo] ADD  CONSTRAINT [DF_TeacherInfo_NIDNo]  DEFAULT ('') FOR [NIDNo]
GO
ALTER TABLE [dbo].[TeacherInfo] ADD  CONSTRAINT [DF_TeacherInfo_ContactNo]  DEFAULT ('') FOR [ContactNo]
GO
ALTER TABLE [dbo].[TeacherInfo] ADD  CONSTRAINT [DF_TeacherInfo_Nationality]  DEFAULT ('') FOR [Nationality]
GO
ALTER TABLE [dbo].[TeacherInfo] ADD  CONSTRAINT [DF_TeacherInfo_Religion]  DEFAULT ('') FOR [Religion]
GO
ALTER TABLE [dbo].[TeacherInfo] ADD  CONSTRAINT [DF_TeacherInfo_Gender]  DEFAULT ('') FOR [Gender]
GO
ALTER TABLE [dbo].[TeacherInfo] ADD  CONSTRAINT [DF_TeacherInfo_ComId]  DEFAULT (1) FOR [ComId]
GO
ALTER TABLE [dbo].[TeacherInfo] ADD  CONSTRAINT [DF_TeacherInfo_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[TeacherInfo] ADD  CONSTRAINT [DF_TeacherInfo_PcName]  DEFAULT ('') FOR [PcName]
GO
ALTER TABLE [dbo].[TeacherInfo] ADD  CONSTRAINT [DF_TeacherInfo_UserCode]  DEFAULT (0) FOR [UserCode]
GO
ALTER TABLE [dbo].[TeachersInfo] ADD  CONSTRAINT [DF_TeachersInfo_T_CodeNo]  DEFAULT ('') FOR [CodeNo]
GO
ALTER TABLE [dbo].[TeachersInfo] ADD  CONSTRAINT [DF_TeachersInfo_T_Name]  DEFAULT ('') FOR [Name]
GO
ALTER TABLE [dbo].[TeachersInfo] ADD  CONSTRAINT [DF_TeachersInfo_F_Name]  DEFAULT ('') FOR [FName]
GO
ALTER TABLE [dbo].[TeachersInfo] ADD  CONSTRAINT [DF_TeachersInfo_M_Name]  DEFAULT ('') FOR [MName]
GO
ALTER TABLE [dbo].[TeachersInfo] ADD  CONSTRAINT [DF_TeachersInfo_Address]  DEFAULT ('') FOR [Address]
GO
ALTER TABLE [dbo].[TeachersInfo] ADD  CONSTRAINT [DF_TeachersInfo_BloodG]  DEFAULT ('') FOR [BloodG]
GO
ALTER TABLE [dbo].[TeachersInfo] ADD  CONSTRAINT [DF_TeachersInfo_InterviewDate]  DEFAULT ('') FOR [InterviewDate]
GO
ALTER TABLE [dbo].[TeachersInfo] ADD  CONSTRAINT [DF_TeachersInfo_CircularDate]  DEFAULT ('') FOR [CircularDate]
GO
ALTER TABLE [dbo].[TeachersInfo] ADD  CONSTRAINT [DF_TeachersInfo_AddMediaName]  DEFAULT ('') FOR [AddMediaName]
GO
ALTER TABLE [dbo].[TeachersInfo] ADD  CONSTRAINT [DF_TeachersInfo_BoardMember]  DEFAULT ('') FOR [BoardMember]
GO
ALTER TABLE [dbo].[TeachersInfo] ADD  CONSTRAINT [DF_TeachersInfo_GovtRepresentative]  DEFAULT ('') FOR [GovtRepresentative]
GO
ALTER TABLE [dbo].[TeachersInfo] ADD  CONSTRAINT [DF_TeachersInfo_InterviewResult]  DEFAULT ('') FOR [InterviewResult]
GO
ALTER TABLE [dbo].[TeachersInfo] ADD  CONSTRAINT [DF_TeachersInfo_SelectedForSub]  DEFAULT ('') FOR [SelectedForSub]
GO
ALTER TABLE [dbo].[TeachersInfo] ADD  CONSTRAINT [DF_TeachersInfo_MPO]  DEFAULT ('') FOR [MPO]
GO
ALTER TABLE [dbo].[TeachersInfo] ADD  CONSTRAINT [DF_TeachersInfo_TypeOfTeacher]  DEFAULT ('') FOR [TypeOfTeacher]
GO
ALTER TABLE [dbo].[TeachersInfo] ADD  CONSTRAINT [DF_TeachersInfo_Paddress]  DEFAULT ('') FOR [Paddress]
GO
ALTER TABLE [dbo].[TeachersInfo] ADD  CONSTRAINT [DF_TeachersInfo_Phone]  DEFAULT ('') FOR [Phone]
GO
ALTER TABLE [dbo].[TeachersInfo] ADD  CONSTRAINT [DF_TeachersInfo_Nation]  DEFAULT ('') FOR [Nation]
GO
ALTER TABLE [dbo].[TeachersInfo] ADD  CONSTRAINT [DF_TeachersInfo_Religious]  DEFAULT ('') FOR [Religious]
GO
ALTER TABLE [dbo].[TeachersInfo] ADD  CONSTRAINT [DF_TeachersInfo_Sex]  DEFAULT ('') FOR [Sex]
GO
ALTER TABLE [dbo].[TeachersInfo] ADD  CONSTRAINT [DF_TeachersInfo_NIdNo]  DEFAULT ('') FOR [NIdNo]
GO
ALTER TABLE [dbo].[TeachersInfo] ADD  CONSTRAINT [DF_TeachersInfo_Dropout]  DEFAULT (0) FOR [Dropout]
GO
ALTER TABLE [dbo].[tem] ADD  CONSTRAINT [DF__tem__entrytime__6EDE3C92]  DEFAULT (getdate()) FOR [entrytime]
GO
ALTER TABLE [dbo].[TemAdvance] ADD  CONSTRAINT [DF_TemAdvance_empid]  DEFAULT ('') FOR [empid]
GO
ALTER TABLE [dbo].[TemAdvance] ADD  CONSTRAINT [DF_TemAdvance_Fromonth]  DEFAULT ('') FOR [Formonth]
GO
ALTER TABLE [dbo].[TemAdvance] ADD  CONSTRAINT [DF_TemAdvance_forYear]  DEFAULT ('') FOR [forYear]
GO
ALTER TABLE [dbo].[TemAdvance] ADD  CONSTRAINT [DF_TemAdvance_AdvDed]  DEFAULT (0) FOR [AdvDed]
GO
ALTER TABLE [dbo].[TemBarcode] ADD  CONSTRAINT [DF_TemBarcode_B1]  DEFAULT ('') FOR [B1]
GO
ALTER TABLE [dbo].[TemBarcode] ADD  CONSTRAINT [DF_TemBarcode_B2]  DEFAULT ('') FOR [B2]
GO
ALTER TABLE [dbo].[TemBarcode] ADD  CONSTRAINT [DF_TemBarcode_B3]  DEFAULT ('') FOR [B3]
GO
ALTER TABLE [dbo].[TemBarcode] ADD  CONSTRAINT [DF_TemBarcode_B4]  DEFAULT ('') FOR [B4]
GO
ALTER TABLE [dbo].[TemBarcode] ADD  CONSTRAINT [DF_TemBarcode_B5]  DEFAULT ('') FOR [B5]
GO
ALTER TABLE [dbo].[TemBarcode] ADD  CONSTRAINT [DF_TemBarcode_Name1]  DEFAULT ('') FOR [Name1]
GO
ALTER TABLE [dbo].[TemBarcode] ADD  CONSTRAINT [DF_TemBarcode_Name2]  DEFAULT ('') FOR [Name2]
GO
ALTER TABLE [dbo].[TemBarcode] ADD  CONSTRAINT [DF_TemBarcode_Name3]  DEFAULT ('') FOR [Name3]
GO
ALTER TABLE [dbo].[TemBarcode] ADD  CONSTRAINT [DF_TemBarcode_Name4]  DEFAULT ('') FOR [Name4]
GO
ALTER TABLE [dbo].[TemBarcode] ADD  CONSTRAINT [DF_TemBarcode_Name5]  DEFAULT ('') FOR [Name5]
GO
ALTER TABLE [dbo].[TemBarcode] ADD  CONSTRAINT [DF_TemBarcode_P1]  DEFAULT ('') FOR [P1]
GO
ALTER TABLE [dbo].[TemBarcode] ADD  CONSTRAINT [DF_TemBarcode_P2]  DEFAULT ('') FOR [P2]
GO
ALTER TABLE [dbo].[TemBarcode] ADD  CONSTRAINT [DF_TemBarcode_P3]  DEFAULT ('') FOR [P3]
GO
ALTER TABLE [dbo].[TemBarcode] ADD  CONSTRAINT [DF_TemBarcode_P4]  DEFAULT ('') FOR [P4]
GO
ALTER TABLE [dbo].[TemBarcode] ADD  CONSTRAINT [DF_TemBarcode_P5]  DEFAULT ('') FOR [P5]
GO
ALTER TABLE [dbo].[TemForItemRpt] ADD  CONSTRAINT [DF_TemForItemRpt_ItemAutoNo]  DEFAULT (0) FOR [ItemAutoNo]
GO
ALTER TABLE [dbo].[TemForItemRpt] ADD  CONSTRAINT [DF_TemForItemRpt_Amt]  DEFAULT (0) FOR [Amt]
GO
ALTER TABLE [dbo].[TemForItemRpt] ADD  CONSTRAINT [DF_TemForItemRpt_PCName]  DEFAULT ('') FOR [PCName]
GO
ALTER TABLE [dbo].[TemForItemRpt] ADD  CONSTRAINT [DF_TemForItemRpt_ItemCode]  DEFAULT ('') FOR [ItemCode]
GO
ALTER TABLE [dbo].[TemForItemRpt] ADD  CONSTRAINT [DF_TemForItemRpt_ComId]  DEFAULT ('') FOR [ComId]
GO
ALTER TABLE [dbo].[TemItemLadger] ADD  CONSTRAINT [DF_TemItemLadger_PrjAutoNo]  DEFAULT (0) FOR [PrjAutoNo]
GO
ALTER TABLE [dbo].[TemItemLadger] ADD  CONSTRAINT [DF_TemItemLadger_ItemAutoNo]  DEFAULT (0) FOR [ItemAutoNo]
GO
ALTER TABLE [dbo].[TemItemLadger] ADD  CONSTRAINT [DF_TemItemLadger_ReqQty]  DEFAULT (0) FOR [ReqQty]
GO
ALTER TABLE [dbo].[TemItemLadger] ADD  CONSTRAINT [DF_TemItemLadger_InQty]  DEFAULT (0) FOR [InQty]
GO
ALTER TABLE [dbo].[TemItemLadger] ADD  CONSTRAINT [DF_TemItemLadger_OutQty]  DEFAULT (0) FOR [OutQty]
GO
ALTER TABLE [dbo].[TemItemLadger] ADD  CONSTRAINT [DF_TemItemLadger_Balance]  DEFAULT (0) FOR [Balance]
GO
ALTER TABLE [dbo].[TemItemLadger] ADD  CONSTRAINT [DF_TemItemLadger_PcName]  DEFAULT ('') FOR [PcName]
GO
ALTER TABLE [dbo].[TemKnit] ADD  CONSTRAINT [DF_TemKnit_BrName]  DEFAULT ('') FOR [BrName]
GO
ALTER TABLE [dbo].[TemKnit] ADD  CONSTRAINT [DF_TemKnit_LotNo]  DEFAULT ('') FOR [LotNo]
GO
ALTER TABLE [dbo].[TemKnit] ADD  CONSTRAINT [DF_TemKnit_InputPrev]  DEFAULT (0) FOR [InputPrev]
GO
ALTER TABLE [dbo].[TemKnit] ADD  CONSTRAINT [DF_TemKnit_InputToday]  DEFAULT (0) FOR [InputToday]
GO
ALTER TABLE [dbo].[TemKnit] ADD  CONSTRAINT [DF_TemKnit_InputTotal]  DEFAULT (0) FOR [InputTotal]
GO
ALTER TABLE [dbo].[TemKnit] ADD  CONSTRAINT [DF_TemKnit_OutputPrev]  DEFAULT (0) FOR [OutputPrev]
GO
ALTER TABLE [dbo].[TemKnit] ADD  CONSTRAINT [DF_TemKnit_OutputToday]  DEFAULT (0) FOR [OutputToday]
GO
ALTER TABLE [dbo].[TemKnit] ADD  CONSTRAINT [DF_TemKnit_OutputTotal]  DEFAULT (0) FOR [OutputTotal]
GO
ALTER TABLE [dbo].[TemKnit] ADD  CONSTRAINT [DF_TemKnit_ShipMentPrev]  DEFAULT (0) FOR [ShipMentPrev]
GO
ALTER TABLE [dbo].[TemKnit] ADD  CONSTRAINT [DF_TemKnit_ShipMentToday]  DEFAULT (0) FOR [ShipMentToday]
GO
ALTER TABLE [dbo].[TemKnit] ADD  CONSTRAINT [DF_TemKnit_ShipMentTotal]  DEFAULT (0) FOR [ShipMentTotal]
GO
ALTER TABLE [dbo].[TemKnit] ADD  CONSTRAINT [DF_TemKnit_ShipmentBalance]  DEFAULT (0) FOR [ShipmentBalance]
GO
ALTER TABLE [dbo].[TemKnit] ADD  CONSTRAINT [DF_TemKnit_FBalance]  DEFAULT (0) FOR [FBalance]
GO
ALTER TABLE [dbo].[TemKnit] ADD  CONSTRAINT [DF_TemKnit_YBalance]  DEFAULT (0) FOR [YBalance]
GO
ALTER TABLE [dbo].[TemKnit2] ADD  CONSTRAINT [DF__TemKnit2__BrName__4B8D40B9]  DEFAULT ('') FOR [BrName]
GO
ALTER TABLE [dbo].[TemKnit2] ADD  CONSTRAINT [DF__TemKnit2__LotNo__4C8164F2]  DEFAULT ('') FOR [LotNo]
GO
ALTER TABLE [dbo].[TemKnit2] ADD  CONSTRAINT [DF__TemKnit2__Qty__4D75892B]  DEFAULT (0) FOR [Qty]
GO
ALTER TABLE [dbo].[TemLadger] ADD  CONSTRAINT [DF__TemLadger__Vouch__14A6EE59]  DEFAULT ('') FOR [VoucherNO]
GO
ALTER TABLE [dbo].[TemLadger] ADD  CONSTRAINT [DF__TemLadger__PCNam__159B1292]  DEFAULT ('') FOR [HeadId]
GO
ALTER TABLE [dbo].[TemLadger] ADD  CONSTRAINT [DF_TemLadger_HeadName]  DEFAULT ('') FOR [HeadName]
GO
ALTER TABLE [dbo].[TemLadger] ADD  CONSTRAINT [DF_TemLadger_Debit]  DEFAULT (0) FOR [Debit]
GO
ALTER TABLE [dbo].[TemLadger] ADD  CONSTRAINT [DF_TemLadger_Credit]  DEFAULT (0) FOR [Credit]
GO
ALTER TABLE [dbo].[TemLadger] ADD  CONSTRAINT [DF_TemLadger_NoteRmk]  DEFAULT ('') FOR [NoteRmk]
GO
ALTER TABLE [dbo].[TemLadger] ADD  CONSTRAINT [DF_TemLadger_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[TemLadger] ADD  CONSTRAINT [DF_TemLadger_PCName]  DEFAULT ('') FOR [PCName]
GO
ALTER TABLE [dbo].[TemLadger] ADD  CONSTRAINT [DF__temladger__Remar__1F247CCC]  DEFAULT ('') FOR [Remarks]
GO
ALTER TABLE [dbo].[TemLadger] ADD  CONSTRAINT [DF_TemLadger_Note]  DEFAULT ('') FOR [Note]
GO
ALTER TABLE [dbo].[TemLadger] ADD  CONSTRAINT [DF_TemLadger_SLNo]  DEFAULT (0) FOR [SLNo]
GO
ALTER TABLE [dbo].[TemLadger] ADD  CONSTRAINT [DF_TemLadger_OpBal]  DEFAULT (0) FOR [OpBal]
GO
ALTER TABLE [dbo].[TemLadger] ADD  CONSTRAINT [DF_TemLadger_ClBal]  DEFAULT (0) FOR [ClBal]
GO
ALTER TABLE [dbo].[TemLadger] ADD  CONSTRAINT [DF_TemLadger_Balance]  DEFAULT (0) FOR [Balance]
GO
ALTER TABLE [dbo].[TemLadger] ADD  CONSTRAINT [DF__temLadger__UserC__568C2254]  DEFAULT ('') FOR [UserCode]
GO
ALTER TABLE [dbo].[TemRpt] ADD  CONSTRAINT [DF_TemRpt_PCName]  DEFAULT ('') FOR [PCName]
GO
ALTER TABLE [dbo].[TemRpt] ADD  CONSTRAINT [DF_TemRpt_ItemAutoNo]  DEFAULT (0) FOR [ItemAutoNo]
GO
ALTER TABLE [dbo].[TemRpt] ADD  CONSTRAINT [DF_TemRpt_ComId]  DEFAULT ('') FOR [ComId]
GO
ALTER TABLE [dbo].[TemStockWithPrice] ADD  CONSTRAINT [DF_TemStockWithPrice_PCName]  DEFAULT ('') FOR [PCName]
GO
ALTER TABLE [dbo].[TemStockWithPrice] ADD  CONSTRAINT [DF_TemStockWithPrice_ItemAutoNo]  DEFAULT (0) FOR [ItemAutoNo]
GO
ALTER TABLE [dbo].[TemStockWithPrice] ADD  CONSTRAINT [DF_TemStockWithPrice_OpeningStockQty]  DEFAULT (0) FOR [OpeningStockQty]
GO
ALTER TABLE [dbo].[TemStockWithPrice] ADD  CONSTRAINT [DF_TemStockWithPrice_OpeningStockPrice]  DEFAULT (0) FOR [OpeningStockPrice]
GO
ALTER TABLE [dbo].[TemStockWithPrice] ADD  CONSTRAINT [DF_TemStockWithPrice_UnitPrice]  DEFAULT (0) FOR [UnitPrice]
GO
ALTER TABLE [dbo].[TemStockWithPrice] ADD  CONSTRAINT [DF_TemStockWithPrice_QtyIn]  DEFAULT (0) FOR [QtyIn]
GO
ALTER TABLE [dbo].[TemStockWithPrice] ADD  CONSTRAINT [DF_TemStockWithPrice_QtyOut]  DEFAULT (0) FOR [QtyOut]
GO
ALTER TABLE [dbo].[TemStockWithPrice] ADD  CONSTRAINT [DF_TemStockWithPrice_QtyInHand]  DEFAULT (0) FOR [ClosingStockQty]
GO
ALTER TABLE [dbo].[TemStockWithPrice] ADD  CONSTRAINT [DF_TemStockWithPrice_TotPrice]  DEFAULT (0) FOR [ClosingStockPrice]
GO
ALTER TABLE [dbo].[TemTradAc] ADD  CONSTRAINT [DF_TemTradAc_Head]  DEFAULT ('') FOR [Head]
GO
ALTER TABLE [dbo].[TemTradAc] ADD  CONSTRAINT [DF_TemTradAc_SubHead]  DEFAULT ('') FOR [SubHead]
GO
ALTER TABLE [dbo].[TemTradAc] ADD  CONSTRAINT [DF_TemTradAc_HeadAmtDr]  DEFAULT (0) FOR [HeadAmtDr]
GO
ALTER TABLE [dbo].[TemTradAc] ADD  CONSTRAINT [DF_TemTradAc_HeadAmtCr]  DEFAULT (0) FOR [HeadAmtCr]
GO
ALTER TABLE [dbo].[TemTradAc] ADD  CONSTRAINT [DF_TemTradAc_SHDr]  DEFAULT (0) FOR [SHDr]
GO
ALTER TABLE [dbo].[TemTradAc] ADD  CONSTRAINT [DF_TemTradAc_SHCr]  DEFAULT (0) FOR [SHCr]
GO
ALTER TABLE [dbo].[TemTradAc] ADD  CONSTRAINT [DF_TemTradAc_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[TemTradAc] ADD  CONSTRAINT [DF_TemTradAc_PCName]  DEFAULT ('') FOR [PCName]
GO
ALTER TABLE [dbo].[TemTradAc] ADD  CONSTRAINT [DF_TemTradAc_SLNo]  DEFAULT (0) FOR [SLNo]
GO
ALTER TABLE [dbo].[TemTradAc] ADD  CONSTRAINT [DF_TemTradAc_ComID]  DEFAULT ('1') FOR [ComID]
GO
ALTER TABLE [dbo].[TemTradAc] ADD  CONSTRAINT [DF__TemTradAc__Type__2D729C23]  DEFAULT ('') FOR [Type]
GO
ALTER TABLE [dbo].[TemUnitPrice] ADD  CONSTRAINT [DF_TemUnitPrice_UnitPrice]  DEFAULT (0) FOR [UnitPrice]
GO
ALTER TABLE [dbo].[TemUnitPrice] ADD  CONSTRAINT [DF_TemUnitPrice_ComID]  DEFAULT ('1') FOR [ComID]
GO
ALTER TABLE [dbo].[TemUnitPrice] ADD  CONSTRAINT [DF_TemUnitPrice_PCName]  DEFAULT ('') FOR [PCName]
GO
ALTER TABLE [dbo].[TemUnitPrice] ADD  CONSTRAINT [DF_TemUnitPrice_OpTotPrice]  DEFAULT (0) FOR [OpTotPrice]
GO
ALTER TABLE [dbo].[TemUnitPrice] ADD  CONSTRAINT [DF_TemUnitPrice_ClosingTotPrice]  DEFAULT (0) FOR [ClosingTotPrice]
GO
ALTER TABLE [dbo].[TemUnitPrice] ADD  CONSTRAINT [DF__temunitpr__OpTot__0B5D7B41]  DEFAULT (0) FOR [OpTotPurQty]
GO
ALTER TABLE [dbo].[TemUnitPrice] ADD  CONSTRAINT [DF__temunitpr__ClTot__0C519F7A]  DEFAULT (0) FOR [ClTotPurQty]
GO
ALTER TABLE [dbo].[TemVoucher] ADD  CONSTRAINT [DF_TemVoucher_UserCode]  DEFAULT ('') FOR [UserCode]
GO
ALTER TABLE [dbo].[TemVoucher] ADD  CONSTRAINT [DF_TemVoucher_VNo]  DEFAULT ('') FOR [VNo]
GO
ALTER TABLE [dbo].[TemVoucher] ADD  CONSTRAINT [DF_TemVoucher_HeadName]  DEFAULT ('') FOR [HeadName]
GO
ALTER TABLE [dbo].[TemVoucher] ADD  CONSTRAINT [DF_TemVoucher_HeadID]  DEFAULT ('') FOR [HeadID]
GO
ALTER TABLE [dbo].[TemVoucher] ADD  CONSTRAINT [DF_TemVoucher_Dr]  DEFAULT (0) FOR [Dr]
GO
ALTER TABLE [dbo].[TemVoucher] ADD  CONSTRAINT [DF_TemVoucher_Cr]  DEFAULT (0) FOR [Cr]
GO
ALTER TABLE [dbo].[TemVoucher] ADD  CONSTRAINT [DF_TemVoucher_Note]  DEFAULT ('') FOR [Note]
GO
ALTER TABLE [dbo].[TemVoucher] ADD  CONSTRAINT [DF_TemVoucher_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[TemVoucher] ADD  CONSTRAINT [DF_TemVoucher_PCName]  DEFAULT ('') FOR [PCName]
GO
ALTER TABLE [dbo].[TemVoucher] ADD  CONSTRAINT [DF_TemVoucher_ComId]  DEFAULT ('') FOR [ComId]
GO
ALTER TABLE [dbo].[TemVoucher] ADD  CONSTRAINT [DF_TemVoucher_D_C]  DEFAULT ('') FOR [D_C]
GO
ALTER TABLE [dbo].[TemVoucher] ADD  CONSTRAINT [DF_TemVoucher_AutoNoFromMstrTbl]  DEFAULT (0) FOR [AutoNoFromMstrTbl]
GO
ALTER TABLE [dbo].[TimeGroup] ADD  CONSTRAINT [DF_TimeGroup_NameRpt]  DEFAULT ('') FOR [NameRpt]
GO
ALTER TABLE [dbo].[TimeGroup] ADD  CONSTRAINT [DF_TimeGroup_MaxOT]  DEFAULT (0) FOR [MaxOT]
GO
ALTER TABLE [dbo].[TimeGroup] ADD  CONSTRAINT [DF_TimeGroup_PcName]  DEFAULT ('') FOR [PcName]
GO
ALTER TABLE [dbo].[TimeGroup] ADD  CONSTRAINT [DF_TimeGroup_UserCode]  DEFAULT (0) FOR [UserCode]
GO
ALTER TABLE [dbo].[TimeGroup] ADD  CONSTRAINT [DF_TimeGroup_ComId]  DEFAULT ('') FOR [ComId]
GO
ALTER TABLE [dbo].[TimeGroup] ADD  CONSTRAINT [DF_TimeGroup_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[TimeGroup] ADD  CONSTRAINT [DF__timegroup__Lunch__19D68321]  DEFAULT (0) FOR [LunchMnt]
GO
ALTER TABLE [dbo].[TKT] ADD  CONSTRAINT [DF__TKT__SLNo__0DCF0841]  DEFAULT (0) FOR [SLNo]
GO
ALTER TABLE [dbo].[TKT] ADD  CONSTRAINT [DF__TKT__Status__0EC32C7A]  DEFAULT ('') FOR [Status]
GO
ALTER TABLE [dbo].[TKT] ADD  CONSTRAINT [DF__TKT__Amount__0FB750B3]  DEFAULT (0) FOR [Amount]
GO
ALTER TABLE [dbo].[TKT] ADD  CONSTRAINT [DF__TKT__Rmk__10AB74EC]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[TKT] ADD  CONSTRAINT [DF_TKT_PurchaseAmt]  DEFAULT (0) FOR [PurchaseAmt]
GO
ALTER TABLE [dbo].[TKT] ADD  CONSTRAINT [DF_TKT_SaleAmt]  DEFAULT (0) FOR [SaleAmt]
GO
ALTER TABLE [dbo].[TOKENNO] ADD  CONSTRAINT [DF_TOKENNO_ComId]  DEFAULT ('1') FOR [ComId]
GO
ALTER TABLE [dbo].[Tution] ADD  CONSTRAINT [DF_Tution_Classname]  DEFAULT ('') FOR [ClassCode]
GO
ALTER TABLE [dbo].[Tution] ADD  CONSTRAINT [DF_Tution_Sid]  DEFAULT ('') FOR [Sid]
GO
ALTER TABLE [dbo].[Tution] ADD  CONSTRAINT [DF_Tution_Tutionfee]  DEFAULT (0) FOR [Fees]
GO
ALTER TABLE [dbo].[Tution] ADD  CONSTRAINT [DF_Tution_Paid]  DEFAULT (0) FOR [Paid]
GO
ALTER TABLE [dbo].[Tution] ADD  CONSTRAINT [DF_Tution_Deu]  DEFAULT (0) FOR [Due]
GO
ALTER TABLE [dbo].[Tution] ADD  CONSTRAINT [DF_Tution_Refund]  DEFAULT (0) FOR [Refund]
GO
ALTER TABLE [dbo].[Tution] ADD  CONSTRAINT [DF_Tution_ForMonth]  DEFAULT ('') FOR [ForMonth]
GO
ALTER TABLE [dbo].[Tution] ADD  CONSTRAINT [DF_Tution_ForYear]  DEFAULT ('') FOR [ForYear]
GO
ALTER TABLE [dbo].[Tution] ADD  CONSTRAINT [DF_Tution_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[Tution] ADD  CONSTRAINT [DF_Tution_ComID]  DEFAULT ('') FOR [ComID]
GO
ALTER TABLE [dbo].[UserVoucher] ADD  CONSTRAINT [DF_UserVoucher_ComID]  DEFAULT ('') FOR [ComID]
GO
ALTER TABLE [dbo].[UserVoucher] ADD  CONSTRAINT [DF_UserVoucher_UserCode]  DEFAULT ('') FOR [UserCode]
GO
ALTER TABLE [dbo].[UserVoucher] ADD  CONSTRAINT [DF_UserVoucher_VNo]  DEFAULT ('') FOR [VNo]
GO
ALTER TABLE [dbo].[UserVoucher] ADD  CONSTRAINT [DF_UserVoucher_HeadName]  DEFAULT ('') FOR [HeadName]
GO
ALTER TABLE [dbo].[UserVoucher] ADD  CONSTRAINT [DF_UserVoucher_Dr]  DEFAULT (0) FOR [Dr]
GO
ALTER TABLE [dbo].[UserVoucher] ADD  CONSTRAINT [DF_UserVoucher_Cr]  DEFAULT (0) FOR [Cr]
GO
ALTER TABLE [dbo].[UserVoucher] ADD  CONSTRAINT [DF_UserVoucher_Note]  DEFAULT ('') FOR [Note]
GO
ALTER TABLE [dbo].[UserVoucher] ADD  CONSTRAINT [DF_UserVoucher_Type]  DEFAULT ('') FOR [Type]
GO
ALTER TABLE [dbo].[Voucher] ADD  CONSTRAINT [DF_Voucher_VoucherNo]  DEFAULT ('') FOR [VoucherNo]
GO
ALTER TABLE [dbo].[Voucher] ADD  CONSTRAINT [DF_Voucher_headId]  DEFAULT (0) FOR [HeadId]
GO
ALTER TABLE [dbo].[Voucher] ADD  CONSTRAINT [DF_Voucher_Dr]  DEFAULT (0) FOR [Dr]
GO
ALTER TABLE [dbo].[Voucher] ADD  CONSTRAINT [DF_Voucher_Cr]  DEFAULT (0) FOR [Cr]
GO
ALTER TABLE [dbo].[Voucher] ADD  CONSTRAINT [DF_Voucher_Rmk]  DEFAULT ('') FOR [Rmk]
GO
ALTER TABLE [dbo].[Voucher] ADD  CONSTRAINT [DF_Voucher_Type]  DEFAULT ('') FOR [VType]
GO
ALTER TABLE [dbo].[Voucher] ADD  CONSTRAINT [DF_Voucher_Note]  DEFAULT ('') FOR [Note]
GO
ALTER TABLE [dbo].[Voucher] ADD  CONSTRAINT [DF_Voucher_SlNo]  DEFAULT ('') FOR [SlNo]
GO
ALTER TABLE [dbo].[Voucher] ADD  CONSTRAINT [DF_Voucher_ComPanyId]  DEFAULT ('1') FOR [ComId]
GO
ALTER TABLE [dbo].[Voucher] ADD  CONSTRAINT [DF_Voucher_Amount]  DEFAULT (0) FOR [Amount]
GO
ALTER TABLE [dbo].[Voucher] ADD  CONSTRAINT [DF_Voucher_D_C]  DEFAULT ('') FOR [D_C]
GO
ALTER TABLE [dbo].[Voucher] ADD  CONSTRAINT [DF__voucher__AutoRmk__361203C5]  DEFAULT ('') FOR [AutoRmk]
GO
ALTER TABLE [dbo].[Voucher] ADD  CONSTRAINT [DF_Voucher_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[Voucher] ADD  CONSTRAINT [DF_Voucher_HeadId2]  DEFAULT (0) FOR [HeadId2]
GO
ALTER TABLE [dbo].[Voucher] ADD  CONSTRAINT [DF__voucher__Custome__21D600EE]  DEFAULT ('') FOR [CustomerId]
GO
ALTER TABLE [dbo].[Voucher] ADD  CONSTRAINT [DF__voucher__PCName__604834B3]  DEFAULT ('') FOR [PCName]
GO
ALTER TABLE [dbo].[Voucher] ADD  CONSTRAINT [DF_Voucher_AutoNoFromVrMstr]  DEFAULT (1) FOR [AutoNoFromMstrTbl]
GO
ALTER TABLE [dbo].[Voucher] ADD  CONSTRAINT [DF_Voucher_UserCode]  DEFAULT ('') FOR [UserCode]
GO
ALTER TABLE [dbo].[Voucher] ADD  CONSTRAINT [DF_Voucher_NoteRmk]  DEFAULT ('') FOR [NoteRmk]
GO
ALTER TABLE [dbo].[Voucher] ADD  CONSTRAINT [DF_Voucher_Cur]  DEFAULT ('') FOR [Cur]
GO
ALTER TABLE [dbo].[Voucher] ADD  CONSTRAINT [DF_Voucher_ConvRate]  DEFAULT (0) FOR [ConvRate]
GO
ALTER TABLE [dbo].[VoucherMstr] ADD  CONSTRAINT [DF_VoucherMstr_PCName]  DEFAULT ('') FOR [PCName]
GO
ALTER TABLE [dbo].[VoucherMstr] ADD  CONSTRAINT [DF_VoucherMstr_EntryTime]  DEFAULT (getdate()) FOR [EntryTime]
GO
ALTER TABLE [dbo].[VoucherMstr] ADD  CONSTRAINT [DF_VoucherMstr_PrjCode]  DEFAULT ('0') FOR [PrjCode]
GO
ALTER TABLE [dbo].[VoucherMstr] ADD  CONSTRAINT [DF_VoucherMstr_UserCode]  DEFAULT ('') FOR [UserCode]
GO
ALTER TABLE [dbo].[VoucherMstr] ADD  CONSTRAINT [DF_VoucherMstr_VoucherNo]  DEFAULT ('') FOR [VoucherNo]
GO
ALTER TABLE [dbo].[VoucherMstr] ADD  CONSTRAINT [DF_VoucherMstr_AutoRmk]  DEFAULT ('') FOR [AutoRmk]
GO
ALTER TABLE [dbo].[VoucherMstr] ADD  CONSTRAINT [DF_VoucherMstr_ComID]  DEFAULT ('1') FOR [ComID]
GO
ALTER TABLE [dbo].[VoucherMstr] ADD  CONSTRAINT [DF_VoucherMstr_PrjAutoNo]  DEFAULT (0) FOR [PrjAutoNo]
GO
ALTER TABLE [dbo].[VoucherMstr] ADD  CONSTRAINT [DF__voucherMstr__Cur__477C86E9]  DEFAULT ('') FOR [Cur]
GO
ALTER TABLE [dbo].[VoucherMstr] ADD  CONSTRAINT [DF__voucherMs__ConvR__4870AB22]  DEFAULT (0) FOR [ConvRate]
GO
ALTER TABLE [dbo].[VoucherMstr] ADD  CONSTRAINT [DF__voucherms__VType__7DA5EF75]  DEFAULT ('') FOR [VrType]
GO
ALTER TABLE [dbo].[VoucherNo] ADD  CONSTRAINT [DF_VoucherNo_PCName]  DEFAULT ('') FOR [PCName]
GO
ALTER TABLE [dbo].[Advance]  WITH CHECK ADD  CONSTRAINT [FK_Advance_Employee] FOREIGN KEY([EmpAutoNo])
REFERENCES [dbo].[Employee] ([EmpAutoNo])
GO
ALTER TABLE [dbo].[Advance] CHECK CONSTRAINT [FK_Advance_Employee]
GO
ALTER TABLE [dbo].[AdvanceDetails]  WITH CHECK ADD  CONSTRAINT [FK_AdvanceDetails_Advance] FOREIGN KEY([EmpAutoNo], [AdvanceCode])
REFERENCES [dbo].[Advance] ([EmpAutoNo], [AdvanceCode])
GO
ALTER TABLE [dbo].[AdvanceDetails] CHECK CONSTRAINT [FK_AdvanceDetails_Advance]
GO
ALTER TABLE [dbo].[DailyAttn]  WITH CHECK ADD  CONSTRAINT [FK_DailyAttn_Employee] FOREIGN KEY([EmpAutoNo])
REFERENCES [dbo].[Employee] ([EmpAutoNo])
GO
ALTER TABLE [dbo].[DailyAttn] CHECK CONSTRAINT [FK_DailyAttn_Employee]
GO
ALTER TABLE [dbo].[Damages]  WITH CHECK ADD  CONSTRAINT [FK_Damages_DamagesMstr] FOREIGN KEY([AutoNoFromMstrTbl])
REFERENCES [dbo].[DamagesMstr] ([AutoNo])
GO
ALTER TABLE [dbo].[Damages] CHECK CONSTRAINT [FK_Damages_DamagesMstr]
GO
ALTER TABLE [dbo].[DamagesMstr]  WITH CHECK ADD  CONSTRAINT [FK_DamagesMstr_Branch] FOREIGN KEY([ComId])
REFERENCES [dbo].[Branch] ([ComID])
GO
ALTER TABLE [dbo].[DamagesMstr] CHECK CONSTRAINT [FK_DamagesMstr_Branch]
GO
ALTER TABLE [dbo].[Education]  WITH CHECK ADD  CONSTRAINT [FK_Education_Employee] FOREIGN KEY([EmpAutoNo])
REFERENCES [dbo].[Employee] ([EmpAutoNo])
GO
ALTER TABLE [dbo].[Education] CHECK CONSTRAINT [FK_Education_Employee]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Department] FOREIGN KEY([DepartmentCode])
REFERENCES [dbo].[Department] ([DepartmentCode])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Department]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Grade] FOREIGN KEY([GradeCode])
REFERENCES [dbo].[Grade] ([GradeCode])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Grade]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Line] FOREIGN KEY([LineCode])
REFERENCES [dbo].[Line] ([LineCode])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Line]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_SectionTbl] FOREIGN KEY([SectionCode])
REFERENCES [dbo].[SectionTbl] ([SectionCode])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_SectionTbl]
GO
ALTER TABLE [dbo].[Experience]  WITH CHECK ADD  CONSTRAINT [FK_Experience_Employee] FOREIGN KEY([EmpAutoNo])
REFERENCES [dbo].[Employee] ([EmpAutoNo])
GO
ALTER TABLE [dbo].[Experience] CHECK CONSTRAINT [FK_Experience_Employee]
GO
ALTER TABLE [dbo].[Increment]  WITH CHECK ADD  CONSTRAINT [FK_Increment_Employee] FOREIGN KEY([EmpAutoNo])
REFERENCES [dbo].[Employee] ([EmpAutoNo])
GO
ALTER TABLE [dbo].[Increment] CHECK CONSTRAINT [FK_Increment_Employee]
GO
ALTER TABLE [dbo].[Leave]  WITH CHECK ADD  CONSTRAINT [FK_Leave_Employee] FOREIGN KEY([EmpAutoNo])
REFERENCES [dbo].[Employee] ([EmpAutoNo])
GO
ALTER TABLE [dbo].[Leave] CHECK CONSTRAINT [FK_Leave_Employee]
GO
ALTER TABLE [dbo].[LeaveTransaction]  WITH CHECK ADD  CONSTRAINT [FK_LeaveTransaction_Employee] FOREIGN KEY([EmpAutoNO])
REFERENCES [dbo].[Employee] ([EmpAutoNo])
GO
ALTER TABLE [dbo].[LeaveTransaction] CHECK CONSTRAINT [FK_LeaveTransaction_Employee]
GO
ALTER TABLE [dbo].[LoginUser]  WITH CHECK ADD  CONSTRAINT [FK_LoginUser_Branch] FOREIGN KEY([ComID])
REFERENCES [dbo].[Branch] ([ComID])
GO
ALTER TABLE [dbo].[LoginUser] CHECK CONSTRAINT [FK_LoginUser_Branch]
GO
ALTER TABLE [dbo].[MarksEntry]  WITH CHECK ADD  CONSTRAINT [FK_MarksEntry_Student] FOREIGN KEY([ComID], [StudentID])
REFERENCES [dbo].[Student] ([ComId], [StudentID])
GO
ALTER TABLE [dbo].[MarksEntry] CHECK CONSTRAINT [FK_MarksEntry_Student]
GO
ALTER TABLE [dbo].[MarksEntry]  WITH CHECK ADD  CONSTRAINT [FK_MarksEntry_Subject] FOREIGN KEY([ComID], [SubjCode])
REFERENCES [dbo].[Subject] ([ComId], [CodeNo])
GO
ALTER TABLE [dbo].[MarksEntry] CHECK CONSTRAINT [FK_MarksEntry_Subject]
GO
ALTER TABLE [dbo].[MonSalary]  WITH CHECK ADD  CONSTRAINT [FK_MonSalary_Department] FOREIGN KEY([DepartmentCode])
REFERENCES [dbo].[Department] ([DepartmentCode])
GO
ALTER TABLE [dbo].[MonSalary] CHECK CONSTRAINT [FK_MonSalary_Department]
GO
ALTER TABLE [dbo].[MonSalary]  WITH CHECK ADD  CONSTRAINT [FK_MonSalary_Employee] FOREIGN KEY([EmpAutoNo])
REFERENCES [dbo].[Employee] ([EmpAutoNo])
GO
ALTER TABLE [dbo].[MonSalary] CHECK CONSTRAINT [FK_MonSalary_Employee]
GO
ALTER TABLE [dbo].[MonSalary]  WITH CHECK ADD  CONSTRAINT [FK_MonSalary_Grade] FOREIGN KEY([GradeCode])
REFERENCES [dbo].[Grade] ([GradeCode])
GO
ALTER TABLE [dbo].[MonSalary] CHECK CONSTRAINT [FK_MonSalary_Grade]
GO
ALTER TABLE [dbo].[MonSalary]  WITH CHECK ADD  CONSTRAINT [FK_MonSalary_Line] FOREIGN KEY([LineCode])
REFERENCES [dbo].[Line] ([LineCode])
GO
ALTER TABLE [dbo].[MonSalary] CHECK CONSTRAINT [FK_MonSalary_Line]
GO
ALTER TABLE [dbo].[MonSalary]  WITH CHECK ADD  CONSTRAINT [FK_MonSalary_SectionTbl] FOREIGN KEY([SectionCode])
REFERENCES [dbo].[SectionTbl] ([SectionCode])
GO
ALTER TABLE [dbo].[MonSalary] CHECK CONSTRAINT [FK_MonSalary_SectionTbl]
GO
ALTER TABLE [dbo].[MonthlyAttn]  WITH CHECK ADD  CONSTRAINT [FK_MonthlyAttn_Employee] FOREIGN KEY([EmpAutoNo])
REFERENCES [dbo].[Employee] ([EmpAutoNo])
GO
ALTER TABLE [dbo].[MonthlyAttn] CHECK CONSTRAINT [FK_MonthlyAttn_Employee]
GO
ALTER TABLE [dbo].[PurchaseMstr]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseMstr_Branch] FOREIGN KEY([COMID])
REFERENCES [dbo].[Branch] ([ComID])
GO
ALTER TABLE [dbo].[PurchaseMstr] CHECK CONSTRAINT [FK_PurchaseMstr_Branch]
GO
ALTER TABLE [dbo].[SaleMstr]  WITH CHECK ADD  CONSTRAINT [FK_SaleMstr_Branch] FOREIGN KEY([ComId])
REFERENCES [dbo].[Branch] ([ComID])
GO
ALTER TABLE [dbo].[SaleMstr] CHECK CONSTRAINT [FK_SaleMstr_Branch]
GO
ALTER TABLE [dbo].[SaleMstr]  WITH CHECK ADD  CONSTRAINT [FK_SaleMstr_PartyInfo] FOREIGN KEY([PartyAuto])
REFERENCES [dbo].[PartyInfo] ([AutoNo])
GO
ALTER TABLE [dbo].[SaleMstr] CHECK CONSTRAINT [FK_SaleMstr_PartyInfo]
GO
ALTER TABLE [dbo].[Scan]  WITH CHECK ADD  CONSTRAINT [FK_Scan_Employee] FOREIGN KEY([EmpAutoNo])
REFERENCES [dbo].[Employee] ([EmpAutoNo])
GO
ALTER TABLE [dbo].[Scan] CHECK CONSTRAINT [FK_Scan_Employee]
GO
ALTER TABLE [dbo].[Security]  WITH CHECK ADD  CONSTRAINT [FK_Security_LoginUser] FOREIGN KEY([UserCode])
REFERENCES [dbo].[LoginUser] ([UserCode])
GO
ALTER TABLE [dbo].[Security] CHECK CONSTRAINT [FK_Security_LoginUser]
GO
ALTER TABLE [dbo].[SettingSingle]  WITH CHECK ADD  CONSTRAINT [FK_SettingSingle_Branch] FOREIGN KEY([ComID])
REFERENCES [dbo].[Branch] ([ComID])
GO
ALTER TABLE [dbo].[SettingSingle] CHECK CONSTRAINT [FK_SettingSingle_Branch]
GO
ALTER TABLE [dbo].[Voucher]  WITH CHECK ADD  CONSTRAINT [FK_Voucher_Branch] FOREIGN KEY([ComId])
REFERENCES [dbo].[Branch] ([ComID])
GO
ALTER TABLE [dbo].[Voucher] CHECK CONSTRAINT [FK_Voucher_Branch]
GO
ALTER TABLE [dbo].[Voucher]  WITH CHECK ADD  CONSTRAINT [FK_Voucher_Head] FOREIGN KEY([HeadId])
REFERENCES [dbo].[Head] ([HeadId])
GO
ALTER TABLE [dbo].[Voucher] CHECK CONSTRAINT [FK_Voucher_Head]
GO
ALTER TABLE [dbo].[Voucher]  WITH CHECK ADD  CONSTRAINT [FK_Voucher_VoucherMstr] FOREIGN KEY([AutoNoFromMstrTbl])
REFERENCES [dbo].[VoucherMstr] ([AutoNo])
GO
ALTER TABLE [dbo].[Voucher] CHECK CONSTRAINT [FK_Voucher_VoucherMstr]
GO
