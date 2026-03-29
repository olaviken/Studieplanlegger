CREATE TABLE [dbo].Emne
(
	Emnekode NVARCHAR (50) NOT NULL PRIMARY KEY,
	Emnenavn NVARCHAR (255) NOT NULL,
	Beskrivelse NVARCHAR (255) NULL,
	FagfeltID INT NOT NULL,

	CONSTRAINT FK_Table_Emne_Fagfelt FOREIGN KEY (FagfeltID) REFERENCES [dbo].Fagfelt (FagfeltID)

)
