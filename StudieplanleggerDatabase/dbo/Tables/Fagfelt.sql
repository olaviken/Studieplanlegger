CREATE TABLE [dbo].[Fagfelt]
(
	FagfeltID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	FagfeltNavn NVARCHAR(100) NOT NULL,
	Beskrivelse NVARCHAR(150),
	FagenhetID INT NOT NULL,

	CONSTRAINT FK_Table_Fagfelt_Fagenhet FOREIGN KEY (FagenhetID) REFERENCES [dbo].Fagenhet (FagenhetId)
)
