CREATE DATABASE FGO;
USE FGO;
CREATE TABLE servantInfo (
	servantID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	servantName varchar(50),
	servantStar INT,
	servantType VARCHAR(30),
	servantImg VARCHAR(255)
);

INSERT INTO servantInfo(servantName, servantStar, servantType, servantImg)
VALUES ('Miyamoto Musashi', 5, 'Saber','Mushashi');
INSERT INTO servantInfo(servantName, servantStar, servantType, servantImg)
VALUES ('Artoria Pendragon', 5, 'Saber','Artoria');
INSERT INTO servantInfo(servantName, servantStar, servantType, servantImg)
VALUES ('Okita Sōji', 5, 'Saber','Okita_saber');
INSERT INTO servantInfo(servantName, servantStar, servantType, servantImg)
VALUES ('Mordred', 5, 'Saber','Mordred');
INSERT INTO servantInfo(servantName, servantStar, servantType, servantImg)
VALUES ('Ryōgi Shiki', 5, 'Saber','Shiki');


INSERT INTO servantInfo(servantName, servantStar, servantType, servantImg)
VALUES ('Lancelot', 4, 'Saber','Lancelot_saber');
INSERT INTO servantInfo(servantName, servantStar, servantType, servantImg)
VALUES ('Suzuka Gozen', 4, 'Saber','Gozen');
INSERT INTO servantInfo(servantName, servantStar, servantType, servantImg)
VALUES ('Lanling Wang', 4, 'Saber','Wang');
INSERT INTO servantInfo(servantName, servantStar, servantType, servantImg)
VALUES ('Yagyū Munenori', 4, 'Saber','Munemori');
INSERT INTO servantInfo(servantName, servantStar, servantType, servantImg)
VALUES ('Tomoe Gozen', 4, 'Saber','Tomoe_gozen');


INSERT INTO servantInfo(servantName, servantStar, servantType, servantImg)
VALUES ('Romulus Quirinus', 5, 'Lancer','Romulus_Quirinus');
INSERT INTO servantInfo(servantName, servantStar, servantType, servantImg)
VALUES ('Ereshkigal', 5, 'Lancer','Ereshkigal');
INSERT INTO servantInfo(servantName, servantStar, servantType, servantImg)
VALUES ('Karna', 5, 'Lancer','Karna');
INSERT INTO servantInfo(servantName, servantStar, servantType, servantImg)
VALUES ('Scáthach', 5, 'Lancer','Scáthach');
INSERT INTO servantInfo(servantName, servantStar, servantType, servantImg)
VALUES ('Enkidu', 5, 'Lancer','Enkidu');


INSERT INTO servantInfo(servantName, servantStar, servantType, servantImg)
VALUES ('Mysterious Alter Ego Λ', 4, 'Lancer','Mysterious_Alter_Ego_Λ');
INSERT INTO servantInfo(servantName, servantStar, servantType, servantImg)
VALUES ('Caenis', 4, 'Lancer','Caenis');
INSERT INTO servantInfo(servantName, servantStar, servantType, servantImg)
VALUES ('Artoria Pendragon (Alter)', 4, 'Lancer','Artoria_Pendragon_(Alter)');
INSERT INTO servantInfo(servantName, servantStar, servantType, servantImg)
VALUES ('Percival', 4, 'Lancer','Percival');
INSERT INTO servantInfo(servantName, servantStar, servantType, servantImg)
VALUES ('Minamoto no Raikō', 4, 'Lancer','Minamoto_no_Raikō');


