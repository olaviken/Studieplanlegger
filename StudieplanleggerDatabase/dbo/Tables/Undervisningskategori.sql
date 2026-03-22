CREATE TABLE [dbo].Undervisningskategori
(
	Id INT Not null IDENTITY(1,1) PRIMARY KEY,
	Kategori NVARCHAR (255) NOT NULL,
	Beskrivelse NVARCHAR (255) NULL,
	Multiplikator BIT NOT NULL
)
