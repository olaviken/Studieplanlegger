CREATE TABLE [dbo].Fagenhet (
    FagenhetId INT NOT NULL Identity(1,1) Primary Key,
    Fagenhetnavn NVARCHAR (255) NOT NULL,
    Leder NVARCHAR (255) NOT NULL,
    Beskrivelse NVARCHAR (255) NOT NULL,
    InstituttID INT NOT NULL,
    
    CONSTRAINT Fk_Table_Fagenhet_Institutt FOREIGN KEY (InstituttID) REFERENCES [dbo].Institutt (Id)
);

