create Database ProjetFinFormationSiteWeb
use ProjetFinFormationSiteWeb

--Les tables--
select * from DIRECTEUR
create table DIRECTEUR (
   ID_DIRECTEUR          int  identity(1,1)                not null,
   NOM                 varchar(30)             null,
   PRENOM             varchar(30)           null,
   DATE_NAISSANCE       datetime             null,
   LIEU_NAISSANCE      varchar(30)            null,
   ADRESSE             varchar(30)             null,
   TELEPHONE           varchar(30)            null,
   EMAIL                varchar(30)           null,
   DIPLOME              varchar(30)             null,
   CIN varchar(30) unique, 
   Mot_De_Passe varchar(30),
   constraint PK_DIRECTEUR primary key nonclustered (ID_DIRECTEUR)
)


create table AGENDA_DIRECTEUR (
   ID_AGENDADIRECTEUR          int  identity(1,1)                not null,
   DATE                 datetime             null,
   TITRE                varchar(30)            null,
   ID_DIRECTEUR    int foreign key references DIRECTEUR(ID_DIRECTEUR)  not null,
   constraint PK_AGENDA_DIRECTEUR primary key nonclustered (ID_AGENDADIRECTEUR)
)


create table EMPLOYE (
   ID_EMPLOYE           int   Identity(1,1)               not null,
   NOM                 varchar(30)            null,
   PRENOM               varchar(30)             null,
   DATE_NAISSANCE       datetime             null,
   LIEU_NAISSANCE      varchar(30)             null,
   ADRESSE             varchar(30)             null,
   TELEPHONE           varchar(30)             null,
   EMAIL               varchar(30)             null,
   DIPLOME             varchar(30)             null,
   POSTE                varchar(30)            null,
   CIN varchar(30) unique,
   Mot_De_Passe varchar(30),
   constraint PK_EMPLOYE primary key nonclustered (ID_EMPLOYE)
)


 create table AGENDA_EMPLOYE (
   ID_AGENDAEMPLOYE           int  Identity(1,1)                not null,
   DATE                 datetime             null,
   TITRE               varchar(30)             null,
   ID_EMPLOYE   int Foreign key references EMPLOYE(ID_EMPLOYE) 
   constraint PK_AGENDA_EMPLOYE primary key nonclustered (ID_AGENDAEMPLOYE)
)

create table CONGE (
   ID_CONGE             int  Identity(1,1)                not null,
   ID_EMPLOYE           int foreign key references EMPLOYE(ID_EMPLOYE)   not null,
   DATE_DEBUT           datetime             null,
   DATE_FIN             datetime             null,
   DURE                 int                  null,
   constraint PK_CONGE primary key nonclustered (ID_CONGE)
)





create table CONVENTION (
   ID_CONVENTION        int     identity(1,1)             not null,
   ID_EMPLOYE           int foreign key references EMPLOYE(ID_EMPLOYE)                  not null,
   TYPE_CONVENTION     varchar(30)             null,
   NOM_CONVENTION      varchar(30)             null,
   DATE_CONVENTION      datetime             null,
   constraint PK_CONVENTION primary key nonclustered (ID_CONVENTION)
)

create table FORMATION_INDIVIDUAL (
   ID_FORMATIONINDIVIDUAL       int   identity(1,1)               not null,
   NOM_FR              varchar(30)           null,
   SECTEUR_ACTIVITE    varchar(30)             null,
   MODE_REGLEMENT      varchar(30)            null,
   constraint PK_FORMATION_INDIVIDUAL primary key nonclustered (ID_FORMATIONINDIVIDUAL),

)


create table ADHERENT (
   ID_ADHERENT          int identity(1,1)                 not null,
   CIN                 varchar(30)             null,
   NOM                 varchar(30)             null,
   PRENOM              varchar(30)            null,
   DATE_NAISSANCE       datetime             null,
   ADRESSE             varchar(30)             null,
   SEXE                varchar(30)             null,
   TELEPHONE           varchar(30)             null,
   ID_FORMATIONINDIVIDUAL int foreign key references FORMATION_INDIVIDUAL(ID_FORMATIONINDIVIDUAL)
   constraint PK_ADHERENT primary key nonclustered (ID_ADHERENT) 
   
)

insert into ADHERENT values('A33445','REQQASS','Kaouthar','03/03/2001','bnikheldoune','Femme','073663838',1)



create table FORMATEUR (
		ID_FORMATEUR int identity(1,1) not null,
		NOM varchar(30) null,
		PRENOM varchar(30) null,
		DATE_NAISSANCE datetime null,
		LIEU_NAISSANCE varchar(30) null,
		ADRESSE varchar(30) null,
		TELEPHONE varchar(30) null,
		EMAIL varchar(30) null,
		CIN varchar(30),
		DIPLOME varchar(30) null,
		POSTE varchar(30) null,
		FONCTION varchar(30) null,
		SPECIALITE varchar(30) null,
		constraint PK_FOR primary key nonclustered (ID_FORMATEUR)
)




create table FORMATION_GROUPE (
   ID_FORMATIONGROUPE        int   identity(1,1)               not null,
   NOM_FR              varchar(30)             null,
   Nom_Entrprise varchar(20),
   SECTEUR_ACTIVITE    varchar(30)             null,
   MISSION            varchar(30)           null,
   OBJECTIF            varchar(30)            null,
   EFFECTIF             int                  null,
   BESOIN_INDIVIDUELE   varchar(30)            null,
   BESOIN               varchar(30)             null,
   constraint PK_FORMATION_GROUPE primary key nonclustered (ID_FORMATIONGROUPE)
)



create table EQUIPE (
   ID_EQUIPE            int identity(1,1)                 not null,
   ID_EMPLOYE           int FOREIGN KEY REFERENCES EMPLOYE(ID_EMPLOYE)    not null,
   NOM_EQUIPE         varchar(30)             null,
   NOMBRE               int                  null,
   ID_FORMATIONINDIVIDUAL int foreign key references FORMATION_INDIVIDUAL(ID_FORMATIONINDIVIDUAL),
   constraint PK_EQUIPE primary key nonclustered (ID_EQUIPE),
   
)

INSert into EQUIPE values(2,'Equipe1',23,1)







create table PAIEMENT_DIRECTEUR (
   ID_PAIEMENTDIRECTEUR       int    identity(1,1)              not null,
   ID_DIRECTEUR   int Foreign key references DIRECTEUR(ID_DIRECTEUR) not null,
   SALAIRE              int                  null,
   PRIME                int                  null,
   SALAIREPRIME         int                  null,
   REGLEMENT           varchar(30)             null,
   DATE_P				Datetime,
   constraint PK_PAIEMENT_DIRECTEUR primary key nonclustered (ID_PAIEMENTDIRECTEUR)
)


create table PAIEMENT_EMPLOYE (
   ID_PAIEMENTEMPLOYE         int    identity(1,1)              not null,
   ID_EMPLOYE           int foreign key references EMPLOYE(ID_EMPLOYE)                  not null,
   SALAIRE              int                  null,
   PRIME                int                  null,
   SALAIREPRIME         int                  null,
   REGLEMENT          varchar(30)             null,
    DATE_P				Datetime,
   constraint PK_PAIEMENT_EMPLOYE primary key nonclustered (ID_PAIEMENTEMPLOYE)
)


create table PAIEMENT_FORMATEUR (
   ID_PAIEMENTFORMATEUR        int     identity(1,1)             not null,
   ID_FORMATEUR       int FOREIGN KEY REFERENCES FORMATEUR(ID_FORMATEUR)                 not null,
   SALAIRE              int                  null,
   PRIME                int                  null,
   SALAIREPRIME         int                  null,
   REGLEMENT           varchar(30)             null,
    DATE_P				Datetime,
   constraint PK_PAIEMENT_FORMATEUR primary key nonclustered (ID_PAIEMENTFORMATEUR)
)

create table SALLE (
   ID_SALLE             int     identity(1,1)             not null,
   CAPACITE             int                  null,
   DISPONIBILITE        VARCHAR(30)                null,
   PRIX                 int                  null,
   constraint PK_SALLE primary key nonclustered (ID_SALLE)

)
create table SALLE_list (
   ID_SALLE             int     identity(1,1)             not null,
   CAPACITE             int                  null,
   DISPONIBILITE        VARCHAR(30)                null,
   PRIX                 int                  null,
   TYPE_SALLE			varchar(30),
   DATE_DISPONIBILITE	date
)
select * from SALLE_list 
--create table EVENEMENT (
--   ID_EVENEMENT         int   identity(1,1)               not null,
--   ID_EMPLOYE           int Foreign key references EMPLOYE(ID_EMPLOYE)   not null,
--   TYPE_EVENEMENT      varchar(30)            null,
--   NOM_EVENEMENT       varchar(30)            null,
--   DATE_EVENEMENT            datetime             null,
--   DURE                 int                  null,
--   PRIX_EVENEMENT       int                  null,
--   constraint PK_EVENEMENT primary key nonclustered (ID_EVENEMENT),
--   iD_SALLE int foreign key references SALLE (ID_SALLE) Default'Aucun' null
--)
create table FORMATEUR_FORMATIONINDIVIDUAL (
   ID_FORMATEUR        int FOREIGN KEY REFERENCES FORMATEUR(ID_FORMATEUR)                  not null,
   ID_FORMATIONINDIVIDUAL      int FOREIGN KEY REFERENCES FORMATION_INDIVIDUAL(ID_FORMATIONINDIVIDUAL)                  not null,
   constraint PK_AVOIR9 primary key nonclustered (ID_FORMATEUR, ID_FORMATIONINDIVIDUAL)
)

create table FORMATEUR_FORMATIONGROUPE (
   ID_FORMATEUR          int FOREIGN KEY REFERENCES FORMATEUR(ID_FORMATEUR)                  not null,
   ID_FORMATIONGROUPE        int FOREIGN KEY REFERENCES FORMATION_GROUPE(ID_FORMATIONGROUPE)                 not null,
   constraint PK_AVOIR10 primary key nonclustered (ID_FORMATEUR, ID_FORMATIONGROUPE)
)

create table CLIENT_EVENEMENT
(
   ID_CLIENT        int primary key identity(1,1)                 not null,
   CIN_CLIENT                 varchar(30)             null,
   NOM_Client                 varchar(30)             null,
   PRENOM_CLIENT               varchar(30)             null,
   DATE_NAISSANCE_CLIENT       datetime             null,
   ADRESSE_CLIENT            varchar(30)             null,
   SEXE_CLIENT                varchar(30)             null,
   TELEPHONE_CLIENT           varchar(30)            null,
   TYPE_EVENEMENT      varchar(30)            null,
   NOM_EVENEMENT       varchar(30)            null,
   DATE_EVENEMENT            datetime             null,
   DURE                 int                  null,
)

select * from CLIENT_SALLE
create table CLIENT_SALLE
(
   ID_CLIENT_SALLE       int primary key identity(1,1)                 not null,
   CIN_CLIENT                 varchar(30)             null,
   NOM_Client                 varchar(30)             null,
   PRENOM_CLIENT               varchar(30)             null,
   DATE_NAISSANCE_CLIENT       datetime             null,
   ADRESSE_CLIENT            varchar(30)             null,
   SEXE_CLIENT                varchar(30)             null,
   TELEPHONE_CLIENT           varchar(30)            null,
   type         varchar(30)            null,
   dateDebut       datetime             null,
   dateFin      datetime             null,

)
alter table CLIENT_SALLE
alter column dateDebut date
alter table CLIENT_SALLE
alter column dateFin date
alter table CLIENT_SALLE
alter column DATE_NAISSANCE_CLIENT date
select * from SALLE_list
select ID_CLIENT_SALLE 'Numéro client',CIN_CLIENT 'CIN',NOM_Client 'Nom Client',PRENOM_CLIENT 'Prénom Client',TELEPHONE_CLIENT 'Téléphone', type 'Type Salle', dateDebut 'Date Début',dateFin 'Date Fin' from CLIENT_SALLE C Order by dateDebut DESC
insert into CLIENT_SALLE values('F4444','El Rhazi','Badr','2000-12-29','Iris','Homme','0689901001','Groupée','2022-04-04','2022-04-10')


--create table RESERVATION
--(
--	ID_RESERVATION int primary key identity(1,1),
--	DATE_RESERVATION Date,
--	ID_CLIENT_SALLE int foreign key references CLIENT_SALLE(ID_CLIENT_SALLE),
--	ID_SALLE int foreign key references SALLE(ID_SALLE),

--)

--Les jeux D'enregistrement--

--La table : EMPLOYE--

insert into EMPLOYE values('ibtissam','btissam','12/04/1980','Oujda','elmanar','0618111827','ibtissam@gmail.com','economie','ConseillereRelationClientele','F3333','b1234')
insert into EMPLOYE values('ALLAOUI','YOUSRA','12/04/2000','Oujda','BNI elmanar','0616930984','YOUSRA@gmail.com','DEV','ResponsableFormation','F0202','v1234')
insert into EMPLOYE values('badr','badr','29/12/2000','Oujda','XXXXXXX','0689901001','rzi.badr@gmail.com','DEV','ResponsableFormation','badr48','b1234')
insert into EMPLOYE values('sadki','Amine','12/04/2001','BERKAN','LAZARI','0613333827','AMINE@gmail.com','economie','AgentAdministratif','F3434','n1234')
------------------------------------------------------------------------------------------------------------------------------------------------------------
select * from AGENDA_EMPLOYE
select * from EMPLOYE
select * from EQUIPE
------------------------------------------------------------------------------------------

create table  EquipeAdherent(
	ID_EQUIPE int foreign key references EQUIPE(ID_EQUIPE),
	ID_ADHERENT int foreign key references ADHERENT( ID_ADHERENT)
)
select * from Archives
create table Archives(
	Nom varchar(30) primary key,
	type varchar(30),
	[date] date

)
------------------------------------------------------------------------------------------

Select * from CONVENTION
Select * from FORMATION_GROUPE
Select * from FORMATION_INDIVIDUAL
alter table FORMATION_INDIVIDUAL
add Etat varchar(30)
SELECT * from SALLE
select * from CLIENT_SALLE
select * from salle
SET IDENTITY_INSERT SALLE ON 
select * from EQUIPE
select * from ADHERENT
select * from AGENDA_DIRECTEUR
update EMPLOYE set Mot_De_Passe='b1234' where CIN='F3333'

------------------------------------------------------------------------------------------------------------------------------------------------------------
--La Table Agenda_Employe--
insert into AGENDA_EMPLOYE values('23/04/2021','bbb',1)
insert into AGENDA_EMPLOYE values('23/04/2011','bAb',2)
insert into AGENDA_EMPLOYE values('23/04/2020','bbEEb',3)
--La table Agenda_Directeur--
insert into AGENDA_DIRECTEUR values('23/04/2021','Rendez-vous1',1)

--la table Directeur--
insert into DIRECTEUR values('Bekkaoui','Abdelmalek','12/08/1980','Oujda','hay elmanar','0618288827','bekkaoui@gmail.com','Droit','F2222','a1234')

--la table Reservation--

--INSERT INTO RESERVATION VALUES('12/4/2021',1,1)

--la table Conge--
insert into CONGE values(1,'12/04/2021','12/05/2021',30)

--la table Convention--
insert into CONVENTION values(2,'Etat','Ofppt','13/03/2020')

--la table fORMATEUR--
insert into FORMATEUR values('ABDELLAOUI','HAJAR','03/04/2001','oujda','kheldoune','063663838','hajar@gmail.com','E33445','info','Formateur','vacataire','infpo')
 
--LA Table Client
--insert into CLIENT values('E321211145','daoudi','wiam','03/04/2008','oujda','Femme','0726363333')

--La Table Formation_Individual--
insert into FORMATION_INDIVIDUAL values('yyyyyyy','hhjhh','Cheque')

--la table Equipe--

--La table Formation_Groupe--
insert into FORMATION_GROUPE values('Gestion','Entreprise1','Informatique','Mission1','Objectif1',10,'BesoinsIn1','Besoins1')

--la table Salle--
insert into SALLE values(20,'Disponible',40)



select * from FORMATION_GROUPE
select * from ADHERENT
select * from CLIENT_SALLE
select * from CLIENT_EVENEMENT