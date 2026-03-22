CREATE TABLE [dbo].Undervisningskategori
(
	Id INT Not null Identity(1,1) PRIMARY KEY,
	Kategori NVARCHAR (255) NOT NULL,
	Beskrivelse NVARCHAR (255) NULL,
	Multiplikator BIT NOT NULL
)
