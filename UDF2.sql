USE SAA
go

--IMPLETADAS
--alunos de uma certa turma
CREATE PROCEDURE SAA.ALUNOS_DA_TURMA (@ID_TURMA INT)
AS
	SELECT *
	FROM SAA.Relacao_ALUNO_TURMA JOIN SAA.ALUNO ON SAA.ALUNO.NMEC = SAA.Relacao_ALUNO_TURMA.NMEC
	WHERE ID_Turma = @ID_TURMA

EXEC SAA.ALUNOS_DA_TURMA 1

--id's de todas as turmas
CREATE PROCEDURE SAA.N_TURMAS
AS
    SELECT ID_TURMA
    FROM SAA.TURMA

EXEC SAA.N_TURMAS

--nome de todos os cursos
CREATE PROCEDURE SAA.NOME_CURSOS
AS
	SELECT DISTINCT Nome_Curso
	FROM SAA.CURSO

EXEC SAA.NOME_CURSOS

--alunos de um certo curso
CREATE PROC SAA.ALUNOS_DO_CURSO (@NOME_CURSO VARCHAR(20) )
AS
	SELECT *
	FROM SAA.ALUNO JOIN SAA.CURSO ON SAA.ALUNO.ID_Curso=SAA.CURSO.ID_Curso
	WHERE Nome_Curso = @NOME_CURSO

EXEC SAA.ALUNOS_DO_CURSO Economia

--alunos de um departamento
CREATE PROC SAA.ALUNO_DE_DEPARTAMENTO (@Nome_Dep VARCHAR(50))
AS
	SELECT *
	FROM (SAA.ALUNO JOIN SAA.CURSO ON SAA.ALUNO.ID_CURSO=SAA.CURSO.ID_CURSO) JOIN SAA.DEPARTAMENTO ON SAA.CURSO.ID_Dep=SAA.DEPARTAMENTO.ID_Dep
	WHERE Nome_Dep = @Nome_Dep

EXEC SAA.ALUNO_DE_DEPARTAMENTO DETI

--NOME DE DEPARTAMENTOS
CREATE PROC SAA.NOME_DEPARTAMENTOS
AS
	SELECT Nome_Dep
	FROM SAA.DEPARTAMENTO

EXEC SAA.NOME_DEPARTAMENTOS

--IDS DOS HORARIOS
CREATE PROC SAA.IDS_HORARIOS
AS
	SELECT ID_Horario
	FROM SAA.HORARIO

EXEC SAA.IDS_HORARIOS

--VER TODOS OS ALUNOS
CREATE PROC SAA.ALUNOS
AS
	SELECT *
	FROM SAA.ALUNO

EXEC SAA.ALUNOS

--ALUNOS DE UM CERTO HORARIO
CREATE PROC SAA.ALUNOS_DO_HORARIO (@ID_Horario INT)
AS
	SELECT *
	FROM SAA.ALUNO
	WHERE ID_Horario = @ID_Horario


EXEC SAA.ALUNOS_DO_HORARIO 5

--PROFESSORES DE UM CERTO HORARIO
CREATE PROC SAA.PROFESSOR_DO_HORARIO (@ID_HORARIO INT)
AS
	SELECT *
	FROM SAA.PROFESSOR
	WHERE ID_Horario = @ID_HORARIO

EXEC SAA.PROFESSOR_DO_HORARIO 4

--TURMAS DE UM CERTO HORAIRO
CREATE PROC SAA.TURMAS_DO_HORARIO (@ID_HORARIO INT)
AS
	SELECT * 
	FROM saa.turma
	WHERE id_horario=@ID_HORARIO

EXEC SAA.TURMAS_DO_HORARIO 5

--UC DE UM CERTO HORARIO
CREATE PROC SAA.UCS_DO_HORARIO (@ID_HORARIO INT)
AS
	SELECT *
	FROM SAA.UC
	WHERE ID_Horario = @ID_Horario

exec SAA.UCS_DO_HORARIo 1

--IDS DAS BIBLIOTECAS EXISTENTES
CREATE PROC SAA.N_BIBLIOS
AS
	select ID_Biblioteca
	from saa.biblioteca

EXEC SAA.N_BIBLIOS

--ALUNOS DA BIBLIO X
CREATE PROC SAA.ALUNOS_DA_BIBLIO (@ID_BIBLIO INT)
AS
	select *
	from saa.aluno
	WHERE ID_Biblioteca = @ID_BIBLIO

EXEC SAA.ALUNOS_DA_BIBLIO 1

--ENTIDADE ALUNO ---------------------------------------------------------------------------------------------------------------------
--UDF ALUNO EM ERASMOS
CREATE FUNCTION SAA.ALUNO_EM_ERASMOS (@Erasmus varchar(50)) RETURNS TABLE
AS 
	RETURN(
		SELECT ALUNO.NMEC, ALUNO.Nome, ALUNO.RegimeEstudo,ID_Biblioteca, ALUNO.Email
		FROM SAA.ALUNO
		WHERE RegimeEstudo=@Erasmus
		)
go

SELECT * FROM SAA.ALUNO_EM_ERASMOS('Erasmus')
go

--Stored Procedure do numero de alunos em erasmos que frequentam a biblioteca
CREATE PROCEDURE SAA.TOTAL_ALUNOS_ERASMOS_BIBLOTECA
AS
	SELECT COUNT(A.ID_Biblioteca)
		FROM SAA.ALUNO AS A
		WHERE RegimeEstudo='Erasmus'
go
EXEC SAA.TOTAL_ALUNOS_ERASMOS_BIBLOTECA
go

-- UDF Alunos da turma X
CREATE FUNCTION SAA.ALUNOS_TURMA_X (@Turma INT) RETURNS TABLE
AS
	RETURN(
		SELECT A.NMEC, A.Nome, A.Email, T.ID_Turma
		FROM SAA.ALUNO AS A JOIN SAA.Relacao_ALUNO_TURMA AS RAT ON A.NMEC=RAT.NMEC
		JOIN SAA.TURMA AS T ON RAT.ID_Turma=T.ID_Turma
		WHERE T.ID_Turma=@Turma
	)
go
SELECT * FROM SAA.ALUNOS_TURMA_X(1)
go 


--Total_Alunos_Por_Curso
CREATE PROCEDURE SAA.Total_Alunos_Por_Curso
AS
	SELECT Nome_Curso, COUNT(NMEC) as Numero_Alunos
	FROM SAA.ALUNO JOIN SAA.CURSO ON SAA.ALUNO.ID_Curso = SAA.CURSO.ID_Curso
	GROUP BY Nome_Curso
go
EXEC SAA.Total_Alunos_Por_Curso

--UDF Horario Aluno PorTurma X
CREATE FUNCTION SAA.Horario_Aluno_PorTurmaX (@turma INT) RETURNS TABLE
AS
	RETURN (
	    SELECT A.NMEC, A.Nome, T.ID_Turma
		FROM SAA.ALUNO AS A JOIN SAA.HORARIO AS H ON A.ID_Horario=H.ID_Horario
		JOIN SAA.TURMA AS T ON H.ID_Horario=T.ID_Horario
		WHERE ID_TURMA=@turma
	)
go
select * from SAA.Horario_Aluno_PorTurmaX(2)
go

--UDF Numero de faltas injustificadas dos alunos a cada uc
CREATE FUNCTION SAA.tipo_faltas_alunos_cada_uc (@Tipo_Falta varchar(30)) RETURNS TABLE
AS
	RETURN (
			SELECT Nome, ID_UC, Tipo_Falta, COUNT(ID_UC) AS NUM_FALTAS
			FROM (SAA.REGISTO JOIN SAA.FALTA ON SAA.REGISTO.ID_Registo = SAA.FALTA.ID_Registo) JOIN SAA.ALUNO ON SAA.ALUNO.NMEC = SAA.REGISTO.NMEC
			WHERE Tipo_Falta = @Tipo_Falta
			GROUP BY Nome, ID_UC, Tipo_Falta
	)
go

select * from SAA.tipo_faltas_alunos_cada_uc('Injustificada')

--update ALUNO
CREATE PROCEDURE SAA.updateALUNO (@Nome VARCHAR(50), @NMEC INT, @Email VARCHAR(50), @RegimeEstudo VARCHAR(50), @ID_Horario INT, @ID_Biblioteca INT, @NMEC_TUTOR INT, @Idade INT, @PasswordAccount VARCHAR(50), @ID_Curso INT)
AS
    UPDATE SAA.ALUNO
    SET Nome = @Nome, NMEC = @NMEC, Email=@Email, RegimeEstudo=@RegimeEstudo, ID_Horario=@ID_Horario, ID_Biblioteca=@ID_Biblioteca, NMEC_TUTOR=@NMEC_TUTOR, Idade=@Idade, PasswordAccount=@PasswordAccount, ID_Curso=@ID_Curso
    WHERE NMEC = @NMEC
GO

EXEC SAA.updateALUNO 'teste', 9999, 'teste123', 'Estudante', 10, 1,  9998, 19,'QWE', 5
--add aluno opçao 2 (OPÇAO 2 A QUE ESTA IMPLEMENTADA)
CREATE PROCEDURE SAA.addALUNO (@Nome VARCHAR(50), @Email VARCHAR(50), @RegimeEstudo VARCHAR(50), @ID_Horario INT, @ID_Biblioteca INT, @NMEC_TUTOR INT, @Idade INT, @PasswordAccount VARCHAR(50), @ID_Curso INT)
AS
	DECLARE @NMECX INT;

	INSERT INTO SAA.ALUNO
	VALUES ( @Nome, @NMECX, @Email, @RegimeEstudo, @ID_Horario, @ID_Biblioteca, @NMEC_TUTOR, @Idade, @PasswordAccount, @ID_Curso )
GO

--add aluno trigger opçao 2
CREATE TRIGGER SAA.addAlunoTrigger ON SAA.ALUNO
INSTEAD OF INSERT
AS
BEGIN
    IF(SELECT count(*) FROM inserted) = 1
    BEGIN
		DECLARE @NMECX INT;

		DECLARE @COUNT INT = 0;
		DECLARE @N_ROWS INT;
        DECLARE @Nome VARCHAR(50);
        DECLARE @Email VARCHAR(50);
        DECLARE @RegimeEstudo VARCHAR(50);
        DECLARE @ID_Horario INT;
        DECLARE @ID_Biblioteca INT;
        DECLARE @NMEC_TUTOR INT;
        DECLARE @Idade INT;
        DECLARE @PasswordAccount VARCHAR(50);
        DECLARE @ID_Curso INT;
        DECLARE @Nome1 VARCHAR(50);
        DECLARE @NMEC1 INT;
        DECLARE @Email1 VARCHAR(50);
        DECLARE @RegimeEstudo1 VARCHAR(50);
        DECLARE @ID_Horario1 INT;
        DECLARE @ID_Biblioteca1 INT;
        DECLARE @NMEC_TUTOR1 INT;
        DECLARE @Idade1 INT;
        DECLARE @PasswordAccount1 VARCHAR(50);
        DECLARE @ID_Curso1 INT;

		DECLARE @ERRO INT = 0;

        SELECT @Nome = Nome, @Email = Email, @RegimeEstudo = RegimeEstudo, @ID_Horario=ID_Horario, @ID_Biblioteca=ID_Biblioteca, @NMEC_TUTOR=NMEC_TUTOR, @Idade=Idade, @PasswordAccount=PasswordAccount, @ID_Curso=ID_Curso FROM inserted 
		SELECT @N_ROWS=COUNT(*) FROM SAA.ALUNO;  
		DECLARE cursorX CURSOR
		FOR SELECT * FROM SAA.ALUNO;
        OPEN cursorX;
        FETCH cursorX INTO @Nome1, @NMEC1, @Email1, @RegimeEstudo1, @ID_Horario1, @ID_Biblioteca1, @NMEC_TUTOR1, @Idade1, @PasswordAccount1, @ID_Curso1;
		--SET @N_ROWS = @N_ROWS-1

		BEGIN TRAN 
			WHILE @@FETCH_STATUS = 0 AND @COUNT < @N_ROWS	--DUVIDA
			BEGIN
				IF(@Email = @Email1)
					BEGIN
						RAISERROR('Email em uso', 16, 1)
						PRINT 'NOT OK'
						SET @ERRO = 1;
					END
				SET @NMECX = @NMEC1 --ANTES OU DEPOIS
				FETCH cursorX INTO @Nome1, @NMEC1, @Email1, @RegimeEstudo1, @ID_Horario1, @ID_Biblioteca1, @NMEC_TUTOR1, @Idade1, @PasswordAccount1, @ID_Curso1
				SET @COUNT = @COUNT + 1;
				
			END;
			SET @NMECX = @NMECX + 1;
			INSERT INTO SAA.ALUNO
			VALUES ( @Nome, @NMECX, @Email, @RegimeEstudo, @ID_Horario, @ID_Biblioteca, @NMEC_TUTOR, @Idade, @PasswordAccount, @ID_Curso )
			IF (@ERRO = 1)
				BEGIN
					ROLLBACK TRAN
				END
		COMMIT TRAN
        CLOSE cursorX;
        DEALLOCATE cursorX;		
    END
END



--adicionar ALUNO
CREATE PROCEDURE SAA.addALUNO (@Nome VARCHAR(50), @NMEC INT, @Email VARCHAR(50), @RegimeEstudo VARCHAR(50), @ID_Horario INT, @ID_Biblioteca INT, @NMEC_TUTOR INT, @Idade INT, @PasswordAccount VARCHAR(50), @ID_Curso INT)
AS
    INSERT INTO SAA.ALUNO
    VALUES ( @Nome, @NMEC, @Email, @RegimeEstudo, @ID_Horario, @ID_Biblioteca, @NMEC_TUTOR, @Idade, @PasswordAccount, @ID_Curso )
GO
EXEC SAA.addALUNO 'teste', 9999, 'teste123', 'Estudante', 10, 1,  9998, 19,'QWE', 5


--Apagar aluno
CREATE PROCEDURE SAA.del_Aluno (@NMEC int) 
AS
	DELETE FROM SAA.ALUNO WHERE NMEC = @NMEC
GO

--APAGAR ALUNO TRIGGER
CREATE TRIGGER SAA.delAlunoTrigger ON SAA.ALUNO
INSTEAD OF DELETE
AS
BEGIN
	BEGIN TRAN
		IF(SELECT count(*) FROM deleted) = 1
		BEGIN
			DECLARE @COUNT INT = 0;
			DECLARE @N_ROWS INT;
			DECLARE @NMEC INT;
			DECLARE @ID_FALTA INT;

			--CURSOR
			DECLARE @ID_Registo1 INT;
			DECLARE @NMEC1 INT;
			DECLARE @ID_UC1 INT;
			DECLARE @ID_Aval1 INT;

			SELECT @NMEC=NMEC FROM deleted
			SELECT @N_ROWS=COUNT(*) FROM SAA.REGISTO;  
			DECLARE cursorX CURSOR
			FOR SELECT * FROM SAA.REGISTO;
			OPEN cursorX;
			FETCH cursorX INTO @ID_Registo1, @NMEC1, @ID_UC1, @ID_Aval1;
			SET @N_ROWS = @N_ROWS-1
			WHILE @COUNT <= @N_ROWS
			BEGIN
				IF ( @NMEC = @NMEC1 )
				BEGIN
					IF EXISTS( SELECT * FROM SAA.FALTA WHERE ID_Registo = @ID_Registo1 )
					BEGIN
						SELECT @ID_FALTA=ID_FALTA FROM SAA.FALTA WHERE ID_Registo = @ID_Registo1
						DELETE SAA.TipoFalta WHERE ID_Falta = @ID_FALTA
						DELETE SAA.FALTA WHERE ID_Registo = @ID_Registo1
					END
					IF EXISTS( SELECT * FROM SAA.NOTA WHERE ID_Registo = @ID_Registo1 )
					BEGIN
						DELETE SAA.NOTA WHERE ID_Registo = @ID_Registo1
					END
				END

				FETCH cursorX INTO @ID_Registo1, @NMEC1, @ID_UC1, @ID_Aval1;
				SET @COUNT = @COUNT + 1;
			END;
			CLOSE cursorX;
			DEALLOCATE cursorX;

			DELETE FROM SAA.Registo WHERE NMEC = @NMEC
			DELETE FROM SAA.Relacao_ALUNO_TURMA WHERE NMEC = @NMEC
			DELETE FROM SAA.ALUNO WHERE NMEC = @NMEC
		END
	COMMIT TRAN
END

--ENTIDADE HORARIO --------------------------------------------------------------
-- add HORARIO
CREATE PROCEDURE SAA.addHorario
AS
	DECLARE @ID_HORARIOX INT;
	INSERT INTO SAA.HORARIO 
	VALUES (@ID_HORARIOX) 
GO

--TRIGGER PARA ADD HORARIOS AUTOMATICAMENTE
CREATE TRIGGER SAA.addHorarioTrigger ON SAA.HORARIO
INSTEAD OF INSERT
AS
BEGIN
	BEGIN TRAN
		IF(SELECT count(*) FROM inserted) = 1
		BEGIN
			DECLARE @COUNT INT = 0;
			DECLARE @N_ROWS INT;
			DECLARE @ID_Horario INT;
			DECLARE @ID_HORARIOX INT;

			SELECT @N_ROWS=COUNT(*) FROM SAA.HORARIO;  
			DECLARE cursorX CURSOR
			FOR SELECT * FROM SAA.HORARIO;
			OPEN cursorX;
			FETCH cursorX INTO @ID_Horario;
			SET @N_ROWS = @N_ROWS-1
			WHILE @COUNT <= @N_ROWS
			BEGIN
				SET @ID_HorariOX = @ID_Horario

				FETCH cursorX INTO @ID_Horario
				SET @COUNT = @COUNT + 1;
			END;
			SET @ID_Horario = @ID_Horario + 1
			CLOSE cursorX;
			DEALLOCATE cursorX;

			INSERT INTO SAA.HORARIO VALUES (@ID_Horario)
		END
	COMMIT TRAN
END


--update horario			APAGAR O UPDATE HORARIO		DROPPED
CREATE PROCEDURE SAA.updateHorario (@ID_Horario INT)
AS
	DECLARE @NEW_Horario
	@NEW_Horario = EXEC SAA.addHorario
	PRINT @ID_Horario 
	PRINT @NEW_Horario

	UPDATE SAA.TURMA
	SET ID_Horario = @NEW_Horario
	WHERE ID_Horario = @ID_Horario

	UPDATE SAA.UC
	SET ID_Horario = @NEW_Horario
	WHERE ID_Horario = @ID_Horario

	UPDATE SAA.PROFESSOR
	SET ID_Horario = @NEW_Horario
	WHERE ID_Horario = @ID_Horario

	UPDATE SAA.ALUNO
	SET ID_Horario = @NEW_Horario
	WHERE ID_Horario = @ID_Horario

	DELETE SAA.HORARIO
	WHERE ID_HORARIO = @ID_HORARIO

GO
DROP PROCEDURE SAA.updateHorario
EXEC SAA.updateHorario 1 , 200

--PROC para apagar horarios
CREATE PROCEDURE SAA.deleteHorario (@ID_Horario INT)
AS
	DELETE SAA.HORARIO
	WHERE ID_Horario = @ID_Horario

EXEC SAA.deleteHorario 2

--TRIGGER PARA APAGAR HORARIOS
CREATE TRIGGER SAA.deleteHorarioTrigger ON SAA.HORARIO
INSTEAD OF delete
AS
	BEGIN
		IF (SELECT count(*) FROM deleted) = 1
		DECLARE @ID_Horario INT;
		BEGIN
			SELECT @ID_Horario=ID_Horario FROM deleted;

			UPDATE SAA.TURMA
			SET ID_Horario = 0
			WHERE ID_Horario = @ID_Horario

			UPDATE SAA.UC
			SET ID_Horario = 0
			WHERE ID_Horario = @ID_Horario

			UPDATE SAA.PROFESSOR
			SET ID_Horario = 0
			WHERE ID_Horario = @ID_Horario

			UPDATE SAA.ALUNO
			SET ID_Horario = 0
			WHERE ID_Horario = @ID_Horario

			DELETE FROM SAA.HORARIO
			WHERE ID_Horario = @ID_Horario
		END
	END

ALTER TABLE

--ENTIDADE REGISTO -----------------------------------------------------------------------------------------------------------------------

--PROC ADD REGISTO
CREATE PROCEDURE SAA.addRegisto (@ID_Registo INT, @NMEC INT, @ID_UC INT, @ID_Aval INT)
AS
	INSERT INTO SAA.REGISTO
	VALUES (@ID_Registo INT, @NMEC INT, @ID_UC INT, @ID_Aval INT)
GO

--TRIGGER PARA ADD REGISTO							TODO: ver
CREATE TRIGGER SAA.addRegistoTrigger ON SAA.REGISTO
INSTEAD OF INSERT
AS
BEGIN
    IF(SELECT count(*) FROM inserted) = 1
    BEGIN
        DECLARE @ID_Registo INT;
        DECLARE @NMEC INT;
        DECLARE @ID_UC INT;
        DECLARE @ID_Aval INT;
		DECLARE @ID_Curso_Aluno INT;
        
		IF (SELECT count(*) FROM inserted) = 1
		BEGIN
			SELECT @NMEC = NMEC, @ID_UC = ID_UC, @ID_Aval = ID_Aval FROM inserted 

			--VERIFICAR SE O NMEC EXISTE E SE O CURSO DO ALUNO TEM A UC DO REGISTO
			IF EXISTS ( SELECT ID_UC FROM SAA.X_UC_DO_ALUNO_X(@NMEC, @ID_UC) )
			BEGIN
				INSERT INTO SAA.REGISTO (NMEC, ID_UC, ID_Aval)
				VALUES (@NMEC, @ID_UC, @ID_Aval)
			END
			ELSE
			BEGIN
				RAISERROR('UC NAO PERTENCE AO CURSO DO ALUNO!',16,1)
			END
		END
    END
END

go

--VERIFICAR SE ID_AVAL EXISTE
CREATE FUNCTION SAA.X_ID_AVAL_DA_UC_X (@ID_UC INT, @ID_Aval INT) RETURNS TABLE
AS
	RETURN(
		SELECT  ID_Aval , ID_UC
		FROM SAA.AVALIACAO
		WHERE ID_Aval = @ID_Aval AND ID_UC = @ID_UC

	)

select * from SAA.X_ID_AVAL_DA_UC_X (2, 1)


GO
--VERIFICAR SE EXISTE A UC PARA CURSO DO ALUNO (USADO NO TRIGGER SAA.addRegistoTrigger)
CREATE FUNCTION SAA.X_UC_DO_ALUNO_X (@NMEC int, @ID_UC INT) RETURNS TABLE
AS
	RETURN(
		SELECT  NMEC , ID_UC
		FROM SAA.Relacao_UC_CURSO JOIN SAA.ALUNO ON SAA.Relacao_UC_CURSO.ID_Curso=SAA.ALUNO.ID_Curso
		WHERE NMEC = @NMEC AND ID_UC = @ID_UC

	)


--VER INFO DO REGISTO
CREATE PROC SAA.INFO_REGISTO ( @ID_Registo INT )
AS
	IF EXISTS ( SELECT * FROM SAA.NOTA WHERE ID_Registo = @ID_Registo )
		BEGIN 
			SELECT * FROM SAA.NOTA WHERE ID_Registo = @ID_Registo
		END
	IF EXISTS ( SELECT * FROM SAA.FALTA WHERE ID_Registo = @ID_Registo )
		BEGIN 
			SELECT * FROM SAA.FALTA WHERE ID_Registo = @ID_Registo
		END




--PROC UPDATE REGISTO					TODO:
CREATE PROCEDURE SAA.updateRegisto (@OLD_ID_Registo INT, @NEW_ID_Registo INT)
AS
	UPDATE 




--UC do curso X
CREATE FUNCTION SAA.UCS_DO_ALUNO (@NMEC int) RETURNS TABLE
AS
	RETURN(
		SELECT  NMEC , ID_UC
		FROM SAA.Relacao_UC_CURSO JOIN SAA.ALUNO ON SAA.Relacao_UC_CURSO.ID_Curso=SAA.ALUNO.ID_Curso
		WHERE NMEC = @NMEC

	)


CREATE FUNCTION SAA.REGISTOS_DO_NMEC (@NMEC INT) RETURNS TABLE
AS
	RETURN (
		SELECT *
		FROM SAA.REGISTO
		WHERE NMEC = @NMEC
		)

	
SELECT * FROM SAA.REGISTOS_DO_NMEC (1)



--ENTIDADE NOTA --------------------------------------------------------------------------------------------------------------------------
--ADD NOTA
CREATE PROC SAA.addNOTA	(@NMEC INT, @ID_UC INT, @ID_AVAL INT, @Nota Decimal)
AS
	DECLARE @ID_NotaX INT;
	DECLARE @ID_Registo INT;

	INSERT INTO SAA.REGISTO (NMEC, ID_UC, ID_Aval)
	VALUES (@NMEC, @ID_UC, @ID_Aval)	

	SELECT TOP 1 @ID_Registo=ID_Registo FROM SAA.REGISTO ORDER BY ID_Registo DESC;
	PRINT @ID_Registo 

	INSERT INTO SAA.NOTA
	VALUES (@ID_NotaX, @Nota, @ID_Registo)

GO

--TRIGGER PARA ADD REGISTO							TODO: ver
CREATE TRIGGER SAA.addRegistoTrigger ON SAA.REGISTO
INSTEAD OF INSERT
AS
BEGIN
    IF(SELECT count(*) FROM inserted) = 1
    BEGIN
        DECLARE @ID_Registo INT;
        DECLARE @NMEC INT;
        DECLARE @ID_UC INT;
        DECLARE @ID_Aval INT;
		DECLARE @ID_Curso_Aluno INT;
        
		IF (SELECT count(*) FROM inserted) = 1
		BEGIN
			SELECT @NMEC = NMEC, @ID_UC = ID_UC, @ID_Aval = ID_Aval FROM inserted 

			--VERIFICAR SE O NMEC EXISTE E SE O CURSO DO ALUNO TEM A UC DO REGISTO
			IF EXISTS ( SELECT ID_UC FROM SAA.X_UC_DO_ALUNO_X(@NMEC, @ID_UC) )
			BEGIN
				INSERT INTO SAA.REGISTO (NMEC, ID_UC, ID_Aval)
				VALUES (@NMEC, @ID_UC, @ID_Aval)
			END
			ELSE
			BEGIN
				RAISERROR('UC NAO PERTENCE AO CURSO DO ALUNO!',16,1)
			END
		END
    END
END


CREATE TRIGGER SAA.addNotaTrigger ON SAA.Nota
INSTEAD OF INSERT
AS
BEGIN
    IF(SELECT count(*) FROM inserted) = 1
    BEGIN
		DECLARE @NMECX INT;

		DECLARE @COUNT INT = 0;
		DECLARE @N_ROWS INT;
       
		DECLARE @ID_NotaX INT = 0;
		DECLARE @Nota Decimal;
		DECLARE @ID_Registo INT;
		DECLARE @ID_NotaX1 INT;
		DECLARE @Nota1 Decimal;
		DECLARE @ID_Registo1 INT;

		DECLARE @ERRO INT = 0;

        SELECT @Nota = Nota, @ID_Registo = ID_Registo FROM inserted 
		SELECT @N_ROWS=COUNT(*) FROM SAA.Nota;  
		DECLARE cursorX CURSOR
		FOR SELECT * FROM SAA.Nota;
        OPEN cursorX;
        FETCH cursorX INTO @ID_NotaX1, @Nota1, @ID_Registo1 ;
		--SET @N_ROWS = @N_ROWS-1

		BEGIN TRAN 
			WHILE @@FETCH_STATUS = 0 AND @COUNT < @N_ROWS
			BEGIN
				IF(@ID_Registo = @ID_Registo1)
					BEGIN
						RAISERROR('Registo em uso', 16, 1)
						SET @ERRO = 1;
					END
				SET @ID_NotaX = @ID_NotaX1
				FETCH cursorX INTO @ID_NotaX1, @Nota1, @ID_Registo1
				SET @COUNT = @COUNT + 1;
				
			END;
			SET @ID_NotaX = @ID_NotaX + 1;
			INSERT INTO SAA.NOTA
			VALUES (@ID_NotaX, @Nota, @ID_Registo)
			
			IF (@ERRO = 1)
				BEGIN
					ROLLBACK TRAN
					Delete SAA.REGISTO WHERE ID_Registo = @ID_Registo				--TODO: alterar para proc?
				END
		COMMIT TRAN
        CLOSE cursorX;
        DEALLOCATE cursorX;		
    END
END







--ENTIDADE PROFESSOR ---------------------------------------------------------------------------------------------------------------------
--UDF total de professores do departamento X
CREATE FUNCTION SAA.TOTAL_PROFESSORES_DEP_X (@Dep INT) RETURNS TABLE
AS
	RETURN (
	    SELECT COUNT(D.ID_Dep) AS TOTAL_PROF_DEP
		FROM SAA.PROFESSOR AS P JOIN SAA.DEPARTAMENTO AS D ON P.ID_DEP=D.ID_Dep
		WHERE D.ID_Dep=@Dep
	)
go
select * from SAA.TOTAL_PROFESSORES_DEP_X(2)
go


--update PROF
CREATE PROCEDURE SAA.insertProf (@Nome_Prof VARCHAR(100), @TMEC int, @Email VARCHAR(100), @Num_Gabinete int, @ID_DEP int, @ID_Horario int)  
AS
	 UPDATE SAA.PROFESSOR
	 SET Nome_Prof = @Nome_Prof, Num_Gabinete = @Num_Gabinete, Email = @Email, TMEC = @TMEC,ID_DEP=@ID_DEP,ID_Horario=@ID_Horario
	 WHERE TMEC = @TMEC
GO

EXEC SAA.insertProf 'Alex',123,'112@as',1,2,3

--add proff trigger VERR
CREATE TRIGGER SAA.addProfTrigger ON SAA.PROFESSOR
AFTER INSERT
AS
BEGIN	
	IF(SELECT count(*) FROM inserted) = 1
	BEGIN
		DECLARE @nomeProf varchar(50);
		DECLARE @num_gab int;
		DECLARE @Email varchar(50);
		DECLARE @tnmec int;
		DECLARE @id_dep int;
		DECLARE @id_Hor int;
		DECLARE @nomeProf1 varchar(50);
		DECLARE @num_gab1 int;
		DECLARE @Email1 varchar(50);
		DECLARE @tnmec1 int;
		DECLARE @id_dep1 int;
		DECLARE @id_Hor1 int;
		SELECT  @nomeProf = Nome_Prof, @num_gab=Num_Gabinete, @Email=Email,@tnmec=TMEC,@id_dep=ID_DEP,@id_Hor=ID_Horario FROM inserted
		DECLARE cursorX CURSOR FOR SELECT * FROM SAA.PROFESSOR
		OPEN cursorX
		FETCH NEXT FROM cursorX INTO @nomeProf1,@num_gab1,@Email1,@tnmec1,@id_dep1,@id_Hor1
		WHILE @@FETCH_STATUS = 0
		BEGIN
			IF(@Email1=@Email AND @num_gab1=@num_gab AND @tnmec1=@tnmec)
			BEGIN 
				RAISERROR('Professor j� existe!',16,1)
				PRINT 'NOT OK'
			END
			FETCH NEXT FROM cursorX INTO @nomeProf1, @num_gab1, @Email1,@tnmec1,@id_dep1,@id_Hor1
		END
		CLOSE cursorX
		DEALLOCATE cursorX
		BEGIN
			INSERT INTO SAA.PROFESSOR VALUES (@nomeProf,@num_gab,@Email,@tnmec,@id_dep,@id_Hor )
			PRINT 'Ok'
		END
	END
END



--Apagar professor
CREATE PROCEDURE SAA.del_Professor (@ID int) 
AS
	DELETE FROM SAA.PROFESSOR WHERE TMEC = @ID
	DELETE FROM SAA.Relacao_UC_PROFESSOR WHERE TMEC = @ID
	DELETE FROM SAA.TURMA WHERE TNEMC = @ID
GO

--trigger caso se apague o professor
CREATE TRIGGER SAA.if_DeleteProfessor ON SAA.PROFESSOR
INSTEAD OF DELETE 
AS
	BEGIN
		BEGIN TRAN
			IF (SELECT count(*) FROM deleted) = 1
			BEGIN
				DECLARE @ID_Prof int
				SELECT @ID_Prof = TMEC FROM deleted
		
				DECLARE @ID_Turma INT
				DECLARE @TNEMC INT      -- relacina-se com o prof
				DECLARE @ID_Horario INT
				DECLARE @AnoLetivo INT
				
				-- para a turma   1:N -> problemas ...
				DECLARE @TableAUX_Turma TABLE (ID_Turma INT, TNEMC INT, ID_Horario INT,AnoLectivo INT );
				INSERT INTO @TableAUX_Turma SELECT ID_Turma, TNEMC, ID_Horario ,AnoLectivo  FROM SAA.TURMA
				
				
				WHILE (SELECT COUNT (*) FROM @TableAUX_Turma) > 0
				BEGIN
					
					SELECT TOP 1  @ID_Turma = ID_Turma, @TNEMC = TNEMC, @ID_Horario = ID_Horario, @AnoLetivo=AnoLectivo  FROM @TableAUX_Turma

					IF (SELECT COUNT(*) FROM SAA.TURMA WHERE @ID_Turma = ID_Turma AND @TNEMC = TNEMC AND @ID_Horario = ID_Horario AND @AnoLetivo=AnoLectivo ) > 0
					BEGIN
						UPDATE TURMA
						SET TNEMC = 0
						WHERE TNEMC = @TNEMC;
						
					END

					DELETE @TableAUX_Turma WHERE @ID_Turma = ID_Turma AND @TNEMC = TNEMC AND @ID_Horario = ID_Horario AND @AnoLetivo=AnoLectivo
				END
				------------------------------------

				DELETE FROM SAA.Relacao_UC_PROFESSOR WHERE TMEC = @ID_Prof
				DELETE FROM SAA.PROFESSOR WHERE TMEC = @ID_Prof
				

			END 
		COMMIT TRAN
	END
GO 

EXEC SAA.del_Professor 1


CREATE PROCEDURE SAA.addProf (@Nome_Prof VARCHAR(100), @TMEC int, @Email VARCHAR(100), @Num_Gabinete int, @ID_DEP int, @ID_Horario int)  
AS
	 INSERT INTO SAA.PROFESSOR (Nome_Prof,Num_Gabinete,Email, TMEC,ID_DEP,ID_Horario)
	 VALUES (@Nome_Prof, @Num_Gabinete, @Email , @TMEC, @ID_DEP , @ID_Horario) 
GO


--FALTA IMPLEMENTAR!
--UDF turmas por professor X
CREATE FUNCTION SAA.TURMAS_POR_PROFESSOR (@ProfName varchar(30)) RETURNS TABLE
AS
	RETURN (
		SELECT T.ID_Turma,P.TMEC,  P.Nome_Prof, P.Email
		FROM SAA.PROFESSOR AS P JOIN SAA.TURMA AS T ON P.TMEC=T.TNEMC
		WHERE P.Nome_Prof=@ProfName
	)
go
select * from SAA.TURMAS_POR_PROFESSOR('Carlos')
go 





--ENTIDADE TURMA
--------------------------------------------------------------------------------------------------------------------------------------------
--if Delete Turma
CREATE TRIGGER ifDeleteTurma ON SAA.TURMA
INSTEAD OF DELETE
AS
BEGIN
	IF (SELECT count(*) FROM deleted) = 1
		BEGIN 
			PRINT 'Ok1'
			DECLARE @idTurma AS int;
			SELECT @idTurma = ID_Turma FROM deleted;

			IF (@idTurma) is null
				RAISERROR('turma inexistente.', 16, 1);
			ELSE
				BEGIN
					PRINT 'Ok2'
					DELETE FROM SAA.Relacao_Turma_Sala WHERE ID_Turma = @idTurma
					DELETE FROM SAA.Relacao_ALUNO_TURMA WHERE ID_Turma = @idTurma
					DELETE FROM SAA.TURMA WHERE ID_Turma = @idTurma
					PRINT 'Ok'
				END
		  END
	  ELSE
		PRINT 'NOPE'
END

-- addTurmaTrigger

CREATE TRIGGER SAA.addTurmaTrigger ON SAA.TURMA
INSTEAD OF INSERT
AS
BEGIN	
	IF(SELECT count(*) FROM inserted) = 1
	BEGIN
		DECLARE @id_turma int;
		DECLARE @Tnmec int;
		DECLARE @id_Horario int;
		DECLARE @AnoLectivo int;
		DECLARE @id_turma1 int;
		DECLARE @Tnmec1 int;
		DECLARE @id_Horario1 int;
		DECLARE @AnoLectivo1 int;
		SELECT  @id_turma = ID_TURMA, @Tnmec=TNEMC, @id_Horario=ID_Horario,@AnoLectivo=AnoLectivo FROM inserted
		DECLARE cursorX CURSOR FOR SELECT * FROM SAA.TURMA
		OPEN cursorX
		FETCH NEXT FROM cursorX INTO @id_turma1,@Tnmec1,@id_Horario1,@AnoLectivo1
		WHILE @@FETCH_STATUS = 0
		BEGIN
			IF(@id_turma1=@id_turma)
			BEGIN 
				RAISERROR('Essa turma j� existe!',16,1)
			END
			FETCH NEXT FROM cursorX INTO @id_turma1, @Tnmec1, @id_Horario1,@AnoLectivo1
		END
		CLOSE cursorX
		DEALLOCATE cursorX
		BEGIN
			INSERT INTO SAA.TURMA VALUES (@id_turma,@Tnmec,@id_Horario,@AnoLectivo)
			PRINT 'Ok'
		END
	END
END



-- add Turma
CREATE PROCEDURE SAA.addTurma (@ID int, @TNMEC int,  @ID_Horario int, @AnoLetivo int)  
AS
	 INSERT INTO SAA.TURMA (ID_Turma,TNEMC,ID_Horario,AnoLectivo)
	 VALUES (@ID, @TNMEC, @ID_Horario , @AnoLetivo ) 
GO



--##########################################################################################################################
-- PRONTO A IMPLEMENTAR!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


--  Alunos da turma Y

CREATE FUNCTION SAA.ALUNOS_TURMA_Y (@Turma INT) RETURNS TABLE
AS
	RETURN(
		SELECT ID_Turma, A.NMEC, Nome,Email, RegimeEstudo, Idade
		FROM SAA.Relacao_ALUNO_TURMA AS RAT JOIN SAA.ALUNO AS A ON RAT.NMEC = A.NMEC
		WHERE ID_Turma = @Turma
	)
go
SELECT * FROM SAA.ALUNOS_TURMA_Y(3)

--  Professores da turma Y

CREATE FUNCTION SAA.PROFESSORES_TURMA_Y (@id_turma varchar(50)) RETURNS TABLE
AS
	RETURN(
		SELECT ID_Turma, T.TNEMC, Nome_Prof,Num_Gabinete, Email
		FROM SAA.TURMA AS T JOIN SAA.PROFESSOR AS P ON T.TNEMC = P.TMEC
		WHERE ID_Turma = @id_turma
	)

-- Turmas e alunos de h� x anos atr�s

CREATE FUNCTION SAA.ALUNOS_TURMA_DE_HA_X_ANOS (@anosAtras INT) RETURNS TABLE
AS
	RETURN(
	SELECT T.ID_Turma, A.NMEC, Nome,Email, RegimeEstudo, Idade,AnoLectivo
	FROM SAA.Relacao_ALUNO_TURMA AS RAT JOIN SAA.ALUNO AS A ON RAT.NMEC = A.NMEC
	JOIN SAA.TURMA AS T ON RAT.ID_Turma = T.ID_Turma 
WHERE YEAR(getdate())-AnoLectivo=@anosAtras )

-- Alunos_Turmas_Do_TipoSala X

CREATE FUNCTION SAA.Alunos_Turmas_Do_TipoSala (@tipoSala varchar(50)) RETURNS TABLE
AS
	RETURN(
	SELECT S.ID_Sala,AnoLectivo, T.ID_Turma, tipoSala,S.Limite_Alunos,DT.ID_Dep
	FROM SAA.TURMA AS T 
	JOIN SAA.Relacao_Turma_Sala AS RTS ON RTS.ID_Turma = T.ID_Turma
	JOIN SAA.SALA AS S ON RTS.ID_Sala = S.ID_Sala
	JOIN SAA.TipoSala AS TS ON TS.ID_Sala = S.ID_Sala
	JOIN SAA.DEPARTAMENTO AS DT ON S.ID_Dep=DT.ID_Dep
	WHERE tipoSala=@tipoSala
)

--update Turma
CREATE PROCEDURE SAA.updateTurma(@idTurma int,  @tnmec int, @id_Horario int, @anoLectivo int) 
AS
	IF (SELECT COUNT(*) FROM SAA.TURMA WHERE ID_Turma = @idTurma ) >0
		BEGIN
			 UPDATE SAA.TURMA
			 SET ID_Turma = @idTurma, TNEMC = @tnmec, ID_Horario =  @id_Horario, AnoLectivo =@anoLectivo
			 WHERE ID_Turma = @idTurma
		END
	ELSE
		BEGIN
			Print 'Nao existe nenhuma turma com esse ID';
		END


--varios joins VER
SELECT S.ID_Sala,AnoLectivo, T.ID_Turma, tipoSala,S.Limite_Alunos,DT.ID_Dep
FROM SAA.TURMA AS T 
JOIN SAA.Relacao_Turma_Sala AS RTS ON RTS.ID_Turma = T.ID_Turma
JOIN SAA.SALA AS S ON RTS.ID_Sala = S.ID_Sala
JOIN SAA.TipoSala AS TS ON TS.ID_Sala = S.ID_Sala
JOIN SAA.DEPARTAMENTO AS DT ON S.ID_Dep=DT.ID_Dep




--ENTIDADE CURSO
--------------------------------------------------------------------------------------------------------------------------------------------
-- Tri add curso

--add proff trigger VERR
CREATE TRIGGER SAA.addCursoTrig ON SAA.CURSO
INSTEAD OF INSERT
AS
BEGIN	--verifica se o curso j� existe
	IF(SELECT count(*) FROM inserted) = 1
	BEGIN 
		DECLARE @nomeCurso varchar(50);
		DECLARE @id_curso int;
		DECLARE @id_dep int;
		
		DECLARE @nomeCurso1 varchar(50);
		DECLARE @id_curso1 int;
		DECLARE @id_dep1 int;
		
		SELECT  @nomeCurso = Nome_Curso, @id_curso=ID_Curso, @id_dep=ID_Dep FROM inserted
		IF(@nomeCurso IS NULL OR  @id_curso IS NULL OR @id_dep IS NULL)
			RAISERROR('Curso j� existe!',16,1)
		
		DECLARE cursorX CURSOR FOR SELECT * FROM SAA.CURSO
		OPEN cursorX
		FETCH NEXT FROM cursorX INTO @nomeCurso1,@id_curso1,@id_dep1
		WHILE @@FETCH_STATUS = 0
		BEGIN
			IF(@id_curso1=@id_curso)
			BEGIN 
				RAISERROR('Curso j� existe!',16,1)
				PRINT 'NOT OK'
			END
			FETCH NEXT FROM cursorX INTO @nomeCurso1, @id_curso1, @id_dep1
		END
		CLOSE cursorX
		DEALLOCATE cursorX
		BEGIN
			insert into SAA.CURSO values ( @nomeCurso,@id_curso,@id_dep)
	   END
	END
END
-- adicionar Curso
CREATE PROCEDURE SAA.addCurso(@nomeCurso varchar(50),  @id_curso int, @id_dep int)  
AS
	insert into SAA.CURSO values ( @nomeCurso,@id_curso,@id_dep)
GO


--update Curso
CREATE PROCEDURE SAA.updateCurso(@nomeCurso varchar(50),  @id_curso int, @id_dep int) 
AS
	IF (SELECT COUNT(*) FROM SAA.CURSO WHERE ID_Curso = @id_curso ) >0
		BEGIN
			 UPDATE SAA.CURSO
			 SET Nome_Curso = @nomeCurso, ID_Curso = @id_curso, ID_Dep = @id_dep
			 WHERE ID_DEP = @id_dep
		END
	ELSE
		BEGIN
			Print 'Nao existe nenhum curso com esse ID';
		END


--eliminar curso
CREATE TRIGGER SAA.if_DeleteCursoTrig ON SAA.CURSO
INSTEAD OF DELETE 
AS
	BEGIN
		BEGIN TRAN
			IF (SELECT count(*) FROM deleted) = 1
			BEGIN
				DECLARE @ID_Curso int
				SELECT @ID_Curso = ID_Curso FROM deleted
				
				DECLARE @Nome varchar(50) -- relacina-se com o aluno
				DECLARE @NMEC INT
				DECLARE @Email varchar(50)      
				DECLARE @RegimeEstudo varchar(50)
				DECLARE @ID_C INT
				
				
				
				-- para a turma   1:N -> problemas ...
				DECLARE @TableAUX_Aluno TABLE (Nome varchar(50), NMEC INT, Email varchar(50),RegimeEstudo varchar(50), ID_Curso INT );
				INSERT INTO @TableAUX_Aluno SELECT Nome, NMEC, Email ,RegimeEstudo, ID_Curso FROM SAA.ALUNO
				
				PRINT 'X'
				WHILE (SELECT COUNT (*) FROM @TableAUX_Aluno) > 0
				BEGIN
					
					SELECT TOP 1  @Nome = Nome, @NMEC = NMEC, @Email = Email, @RegimeEstudo=RegimeEstudo, @ID_C=ID_Curso  FROM @TableAUX_Aluno

					IF (SELECT COUNT(*) FROM SAA.ALUNO WHERE @Nome = Nome AND @NMEC = NMEC AND  @Email = Email AND @RegimeEstudo=RegimeEstudo AND  @ID_C =ID_Curso  ) > 0
					BEGIN
						
						PRINT 'Y'
						UPDATE SAA.ALUNO
						SET ID_Curso = null
						WHERE ID_Curso = @ID_C ;
						print 'ok'
					END

					DELETE @TableAUX_Aluno WHERE @Nome = Nome AND @NMEC = NMEC AND  @Email = Email AND @RegimeEstudo=RegimeEstudo  AND  @ID_C =ID_Curso 
				END
				------------------------------------
				PRINT 'k'
				
				DELETE FROM SAA.Relacao_UC_Curso WHERE ID_Curso = @ID_Curso
				DELETE FROM SAA.CURSO WHERE  ID_Curso = @ID_Curso
				
				PRINT 'C'
				

			END 
		COMMIT TRAN
	END
GO 

--del curso
CREATE PROCEDURE SAA.delCurso (@ID_Curso int) 
AS
	DELETE FROM SAA.CURSO WHERE ID_Curso = @ID_Curso
GO

--UC do curso X
CREATE FUNCTION SAA.UC_DO_CURSO_X (@id_uc int) RETURNS TABLE
AS
	RETURN(
		SELECT RUC.ID_UC,AnoFormacao, Nome_Curso
		FROM SAA.UC AS U 
		JOIN SAA.Relacao_UC_CURSO AS RUC ON U.ID_UC=RUC.ID_UC
		JOIN SAA.CURSO AS C ON C.ID_Curso = RUC.ID_UC
		WHERE C.ID_Curso=@id_uc
	)

-- os anos que cada UC tem em cada curso
CREATE PROC oldest_UC 
AS
BEGIN
	SELECT RUC.ID_UC, Nome_Curso, DATEDIFF(year, AnoFormacao, CONVERT (date, SYSDATETIME())) AS Duracao_UC
	FROM SAA.UC AS U 
	JOIN SAA.Relacao_UC_CURSO AS RUC ON U.ID_UC=RUC.ID_UC
	JOIN SAA.CURSO AS C ON C.ID_Curso = RUC.ID_UC
	ORDER BY AnoFormacao
END
go


























































--Stored Procedure de turmas e salas
CREATE PROCEDURE SAA.TURMAS_E_SALAS 
AS
	SELECT AT1.NMEC, AT1.Nome,AT1.Email, AT1.ID_Turma
	FROM ALUNOS_TURMA_1 AS AT1 JOIN SAA.Relacao_Turma_Sala AS RTS ON AT1.ID_Turma=RTS.ID_Turma
	JOIN SAA.SALA AS S ON RTS.ID_Sala=S.ID_Sala
go
EXEC SAA.TURMAS_E_SALAS 
go

--UDF turmas por professor X
CREATE FUNCTION SAA.TURMAS_POR_PROFESSOR (@ProfName varchar(30)) RETURNS TABLE
AS
	RETURN (
		SELECT T.ID_Turma,P.TMEC,  P.Nome_Prof, P.Email
		FROM SAA.PROFESSOR AS P JOIN SAA.TURMA AS T ON P.TMEC=T.TNEMC
		WHERE P.Nome_Prof=@ProfName
	)
go
select * from SAA.TURMAS_POR_PROFESSOR('Carlos')
go 





--Stored Procedure  de que departamento sao os professores
CREATE PROC SAA.PROFESSOR_DEPARTAMENO  
AS
	SELECT Nome_Prof, TMEC, Nome_Dep
	FROM SAA.DEPARTAMENTO JOIN SAA.PROFESSOR ON SAA.DEPARTAMENTO.ID_Dep = SAA.PROFESSOR.ID_DEP

go
EXEC SAA.PROFESSOR_DEPARTAMENO
go



--UDF uc's de cada curso
CREATE PROCEDURE SAA.UCS_POR_CURSO
AS
	SELECT Nome_Curso, ID_UC
	FROM SAA.Relacao_UC_CURSO JOIN SAA.CURSO ON SAA.Relacao_UC_CURSO.ID_Curso = SAA.CURSO.ID_Curso
	ORDER BY Nome_Curso OFFSET 0 ROWS;
go
EXEC SAA.UCS_POR_CURSO
go






--- NOTAS

CREATE TRIGGER checkDuplicate ON tblData
AFTER INSERT
AS

IF EXISTS ( SELECT * FROM tblData A 
INNER JOIN inserted B ON B.name=A.name and A.Date=B.Date)
BEGIN
    RAISERROR ('Dah! already exists', 16, 1);
END
GO  