CREATE TABLE [dbo].Aktivitet
(
	Id INT NOT NULL Identity(1,1) PRIMARY KEY,
	Beskrivelse NVARCHAR(100) NOT NULL,
	Dato DATE NOT NULL,
	AntallTimer INT NOT NULL,
	Undervisningskategori INT NOT NULL, 
	Emne NVARCHAR(50) NOT NULL,
	
	Foreign Key (Emne) REFERENCES [dbo].Emne (Emnekode),
	Foreign Key (Undervisningskategori) REFERENCES [dbo].Undervisningskategori (Id),

)
