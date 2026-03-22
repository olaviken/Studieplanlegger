CREATE TABLE [dbo].Aktivitet
(
	Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Beskrivelse NVARCHAR(100) NOT NULL,
	Dato DATE NOT NULL,
	AntallTimer INT NOT NULL,
	BeregnetTimer INT,
	Undervisningskategori INT NOT NULL, 
	Emne NVARCHAR(50) NOT NULL,
	UndervisersEpost NVARCHAR(50) NOT NULL,

	CONSTRAINT FK_Table_Aktivitet_Emne FOREIGN KEY (Emne) REFERENCES [dbo].Emne (Emnekode),
	CONSTRAINT FK_Table_Aktivitet_Undervisningskategori FOREIGN KEY (Undervisningskategori) REFERENCES [dbo].Undervisningskategori (Id),
	CONSTRAINT FK_Table_Aktivitet_Underviser FOREIGN KEY (UndervisersEpost) REFERENCES [dbo].Ansatt (Epost),

)
