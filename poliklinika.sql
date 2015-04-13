/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     30.05.2013 19:48:47                          */
/*==============================================================*/
use master
go
create database "043_3_bolnica"
ON
(NAME='043_3_bolnica',
 /*FILENAME='d:\users\stud\db\043\043_3_bolnica.mdf',*/
 FILENAME='c:\program files\microsoft sql server\mssql.1\mssql\data\043_3_bolnica.mdf',
 SIZE=3,
 MAXSIZE=10,
 FILEGROWTH=1)
LOG ON
(NAME='043_3_bolnica_log',
 FILENAME='c:\program files\microsoft sql server\mssql.1\mssql\data\043_3_bolnica.ldf',
 SIZE=1,
 MAXSIZE=10,
 FILEGROWTH=1)
go
use "043_3_bolnica"
go

/*==============================================================*/
/* Table: DistrictDoctors                                       */
/*==============================================================*/
create table DistrictDoctors (
   number               int                  not null,
   "����� �������"      int                  null
)
go

alter table DistrictDoctors
   add constraint PK_DISTRICTDOCTORS primary key nonclustered (number)
go

/*==============================================================*/
/* Table: DistrictSchedule                                      */
/*==============================================================*/
create table DistrictSchedule (
   ID                   int                  identity,
   DistrictDoctors      int                  not null,
   "����� ��������"     int                  null,
   "����� ������"       datetime             not null
)
go

alter table DistrictSchedule
   add constraint PK_DISTRICTSCHEDULE primary key nonclustered (ID)
go

/*==============================================================*/
/* Table: Districts                                             */
/*==============================================================*/
create table Districts (
   "����� �������"      int                  not null
)
go

alter table Districts
   add constraint PK_DISTRICTS primary key nonclustered ("����� �������")
go

/*==============================================================*/
/* Table: Pacient                                               */
/*==============================================================*/
create table Pacient (
   PolicyNumber         int                  identity,
   "����� �������"      int                  null,
   �������              varchar(60)          not null,
   ���                  varchar(30)          not null,
   ��������             varchar(60)          null
)
go

alter table Pacient
   add constraint PK_PACIENT primary key nonclustered (PolicyNumber)
go

/*==============================================================*/
/* Table: ProcedureRoom                                         */
/*==============================================================*/
create table ProcedureRoom (
   NumberProcCab        int                  not null
)
go

alter table ProcedureRoom
   add constraint PK_PROCEDUREROOM primary key nonclustered (NumberProcCab)
go

/*==============================================================*/
/* Table: ProcedureSchedule                                     */
/*==============================================================*/
create table ProcedureSchedule (
   ID                   int                  identity,
   ProcedureRoom        int                  null,
   "����� ������"       datetime             not null
)
go

alter table ProcedureSchedule
   add constraint PK_PROCEDURESCHEDULE primary key nonclustered (ID)
go

/*==============================================================*/
/* Table: Record                                                */
/*==============================================================*/
create table Record (
   Services             int                  not null,
   coupons              int                  not null
)
go

alter table Record
   add constraint PK_RECORD primary key nonclustered (Services, coupons)
go

/*==============================================================*/
/* Table: RenderedService                                       */
/*==============================================================*/
create table RenderedService (
   RServiceNumber       int                  identity,
   Services             int                  not null,
   Pacient2             int                  null,
   ����                 datetime             not null
)
go

alter table RenderedService
   add constraint PK_RENDEREDSERVICE primary key nonclustered (RServiceNumber)
go

/*==============================================================*/
/* Table: Room                                                  */
/*==============================================================*/
create table Room (
   "����� ��������"     int                  not null
)
go

alter table Room
   add constraint PK_ROOM primary key nonclustered ("����� ��������")
go

/*==============================================================*/
/* Table: Services                                              */
/*==============================================================*/
create table Services (
   ServiceNumber        int                  identity,
   ProcedureRoom        int                  null,
   ���������            money                not null,
   ��������             varchar(150)         not null
)
go

alter table Services
   add constraint PK_SERVICES primary key nonclustered (ServiceNumber)
go

/*==============================================================*/
/* Table: SpecialDoctors                                        */
/*==============================================================*/
create table SpecialDoctors (
   number               int                  not null,
   �������������        varchar(60)          not null
)
go

alter table SpecialDoctors
   add constraint PK_SPECIALDOCTORS primary key nonclustered (number)
go

/*==============================================================*/
/* Table: SpecialSchedule                                       */
/*==============================================================*/
create table SpecialSchedule (
   ID                   int                  identity,
   SpecialDoctors       int                  not null,
   "����� ��������"     int                  null,
   "����� ������"       datetime             not null
)
go

alter table SpecialSchedule
   add constraint PK_SPECIALSCHEDULE primary key nonclustered (ID)
go

/*==============================================================*/
/* Table: coupons                                               */
/*==============================================================*/
create table coupons (
   "Number coupon"      int                  identity,
   Pacient              int                  not null,
   "���� ������"        datetime             not null
)
go

alter table coupons
   add constraint PK_COUPONS primary key nonclustered ("Number coupon")
go

/*==============================================================*/
/* Table: doctor                                                */
/*==============================================================*/
create table doctor (
   number               int                  not null,
   �������              varchar(60)          not null,
   ���                  varchar(30)          not null,
   ��������             varchar(60)          null,
   �������              int                  null
)
go

alter table doctor
   add constraint PK_DOCTOR primary key nonclustered (number)
go

/*==============================================================*/
/* Table: ��������������                                        */
/*==============================================================*/
create table �������������� (
   �����                varchar(100)         not null,
   ������               varchar(100)         not null,
   ���                  varchar(10)          null
)
go

alter table ��������������
   add constraint PK_�������������� primary key (�����)
go

/*==============================================================*/
/* Table: �����                                                 */
/*==============================================================*/
create table ����� (
   ID_������            int                  identity,
   doctor               int                  not null,
   Pacient              int                  not null,
   "����� ������"       datetime             not null,
   �������              varchar(500)         null
)
go
alter table DistrictDoctors
   add constraint FK_DISTRICT_WHEREWORK_DISTRICT foreign key ("����� �������")
      references Districts (DistrictNumber)
         on update cascade on delete cascade
go

alter table DistrictDoctors
   add constraint FK_DISTRICT_�����2_DOCTOR foreign key (number)
      references doctor (number)
         on update cascade on delete cascade
go

alter table DistrictSchedule
   add constraint FK_DISTRICT_DISTRICTD_DISTRICT foreign key (DistrictDoctors)
      references DistrictDoctors (number)
         on update cascade on delete cascade
go

alter table DistrictSchedule
   add constraint FK_DISTRICT_WHERE_WOR_ROOM foreign key (Room)
      references Room (RoomNumber)
         on update cascade on delete cascade
go

alter table Pacient
   add constraint FK_PACIENT_ONDISTRIC_DISTRICT foreign key (Districts)
      references Districts (DistrictNumber)
         on update cascade on delete cascade
go

alter table ProcedureSchedule
   add constraint FK_PROCEDUR_WHERE_WOR_PROCEDUR foreign key (ProcedureRoom)
      references ProcedureRoom (NumberProcCab)
         on update cascade on delete cascade
go

alter table Record
   add constraint FK_RECORD_RECORD_SERVICES foreign key (Services)
      references Services (ServiceNumber)
         on update cascade on delete cascade
go

alter table Record
   add constraint FK_RECORD_RECORD2_COUPONS foreign key (coupons)
      references coupons ("Number coupon")
         on update cascade on delete cascade
go

alter table RenderedService
   add constraint FK_RENDERED_SERVICES_SERVICES foreign key (Services)
      references Services (ServiceNumber)
         on update cascade on delete cascade
go

alter table RenderedService
   add constraint FK_RENDERED_WHATSERVI_PACIENT foreign key (Pacient2)
      references Pacient (PolicyNumber)
         on update cascade on delete cascade
go

alter table Services
   add constraint FK_SERVICES_WHEREPROC_PROCEDUR foreign key (ProcedureRoom)
      references ProcedureRoom (NumberProcCab)
         on update cascade on delete cascade
go

alter table SpecialDoctors
   add constraint FK_SPECIALD_�����_DOCTOR foreign key (number)
      references doctor (number)
         on update cascade on delete cascade
go

alter table SpecialSchedule
   add constraint FK_SPECIALS_SPECIALDO_SPECIALD foreign key (SpecialDoctors)
      references SpecialDoctors (number)
         on update cascade on delete cascade
go

alter table SpecialSchedule
   add constraint FK_SPECIALS_WHERE_WOR_ROOM foreign key (Room)
      references Room (RoomNumber)
         on update cascade on delete cascade
go

alter table coupons
   add constraint FK_COUPONS_WHORECORD_PACIENT foreign key (Pacient)
      references Pacient (PolicyNumber)
         on update cascade on delete cascade
go

alter table �����
   add constraint FK_�����_���������_DOCTOR foreign key (doctor)
      references doctor (number)
         on update cascade on delete cascade
go

alter table �����
   add constraint "FK_�����_������ ��_PACIENT" foreign key (Pacient)
      references Pacient (PolicyNumber)
         on update cascade on delete cascade
go

alter table �����
   add constraint PK_����� primary key nonclustered (ID_������)
go
create PROC HPCheckAdmin (@����� char(100),
							@������ char(100),
							@��� char(10),
							@��� int OUTPUT)
AS
IF EXISTS (SELECT *
			FROM ��������������
				WHERE @����� = ����� AND @������ = ������ AND @���=���) 
	SET @��� = 0
ELSE
	SET @��� = 1
--------------------------------------------------
alter PROC HPAddDistrictDoctors (@number int,
						@������� char(60), 
						@��� char(30), 
						@�������� char(60),
						@������� int,
						--@number int
						@������������ int)
AS

--SELECT @number = number
--	FROM doctor
--		WHERE number = @number
--SELECT @number = number
--	FROM DistrictDoctors
--		WHERE number = @number
INSERT INTO Doctor (number,�������,���,��������,�������)
VALUES(@number,@�������, @��� , @��������,@�������)


