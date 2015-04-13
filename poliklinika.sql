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
   "номер участка"      int                  null
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
   "номер кабинета"     int                  null,
   "Время приема"       datetime             not null
)
go

alter table DistrictSchedule
   add constraint PK_DISTRICTSCHEDULE primary key nonclustered (ID)
go

/*==============================================================*/
/* Table: Districts                                             */
/*==============================================================*/
create table Districts (
   "номер участка"      int                  not null
)
go

alter table Districts
   add constraint PK_DISTRICTS primary key nonclustered ("номер участка")
go

/*==============================================================*/
/* Table: Pacient                                               */
/*==============================================================*/
create table Pacient (
   PolicyNumber         int                  identity,
   "номер участка"      int                  null,
   Фамилия              varchar(60)          not null,
   Имя                  varchar(30)          not null,
   Отчество             varchar(60)          null
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
   "Время приема"       datetime             not null
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
   дата                 datetime             not null
)
go

alter table RenderedService
   add constraint PK_RENDEREDSERVICE primary key nonclustered (RServiceNumber)
go

/*==============================================================*/
/* Table: Room                                                  */
/*==============================================================*/
create table Room (
   "номер кабинета"     int                  not null
)
go

alter table Room
   add constraint PK_ROOM primary key nonclustered ("номер кабинета")
go

/*==============================================================*/
/* Table: Services                                              */
/*==============================================================*/
create table Services (
   ServiceNumber        int                  identity,
   ProcedureRoom        int                  null,
   Стоимость            money                not null,
   Название             varchar(150)         not null
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
   Специализация        varchar(60)          not null
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
   "номер кабинета"     int                  null,
   "Время приема"       datetime             not null
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
   "дата приема"        datetime             not null
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
   Фамилия              varchar(60)          not null,
   Имя                  varchar(30)          not null,
   Отчество             varchar(60)          null,
   кабинет              int                  null
)
go

alter table doctor
   add constraint PK_DOCTOR primary key nonclustered (number)
go

/*==============================================================*/
/* Table: Администраторы                                        */
/*==============================================================*/
create table Администраторы (
   Логин                varchar(100)         not null,
   Пароль               varchar(100)         not null,
   Тип                  varchar(10)          null
)
go

alter table Администраторы
   add constraint PK_АДМИНИСТРАТОРЫ primary key (Логин)
go

/*==============================================================*/
/* Table: Прием                                                 */
/*==============================================================*/
create table Прием (
   ID_Приема            int                  identity,
   doctor               int                  not null,
   Pacient              int                  not null,
   "время приема"       datetime             not null,
   диагноз              varchar(500)         null
)
go
alter table DistrictDoctors
   add constraint FK_DISTRICT_WHEREWORK_DISTRICT foreign key ("номер участка")
      references Districts (DistrictNumber)
         on update cascade on delete cascade
go

alter table DistrictDoctors
   add constraint FK_DISTRICT_ВРАЧИ2_DOCTOR foreign key (number)
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
   add constraint FK_SPECIALD_ВРАЧИ_DOCTOR foreign key (number)
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

alter table Прием
   add constraint FK_ПРИЕМ_ОСУЩЕСТВЛ_DOCTOR foreign key (doctor)
      references doctor (number)
         on update cascade on delete cascade
go

alter table Прием
   add constraint "FK_ПРИЕМ_ПРИШЕЛ НА_PACIENT" foreign key (Pacient)
      references Pacient (PolicyNumber)
         on update cascade on delete cascade
go

alter table Прием
   add constraint PK_ПРИЕМ primary key nonclustered (ID_Приема)
go
create PROC HPCheckAdmin (@Логин char(100),
							@Пароль char(100),
							@Тип char(10),
							@Код int OUTPUT)
AS
IF EXISTS (SELECT *
			FROM Администраторы
				WHERE @Логин = Логин AND @Пароль = Пароль AND @Тип=Тип) 
	SET @Код = 0
ELSE
	SET @Код = 1
--------------------------------------------------
alter PROC HPAddDistrictDoctors (@number int,
						@Фамилия char(60), 
						@Имя char(30), 
						@Отчество char(60),
						@Кабинет int,
						--@number int
						@НомерУчастка int)
AS

--SELECT @number = number
--	FROM doctor
--		WHERE number = @number
--SELECT @number = number
--	FROM DistrictDoctors
--		WHERE number = @number
INSERT INTO Doctor (number,Фамилия,Имя,Отчество,Кабинет)
VALUES(@number,@Фамилия, @Имя , @Отчество,@Кабинет)


