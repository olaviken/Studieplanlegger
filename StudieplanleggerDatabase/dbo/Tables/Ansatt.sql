CREATE TABLE [dbo].Ansatt (
    Epost NVARCHAR (50)  NOT NULL PRIMARY KEY,
    Etternavn NVARCHAR (50)  NOT NULL,
    Fornavn NVARCHAR (50)  NOT NULL,
    Fodselsdato DATE NOT NULL,
    Stillingprosent INT NULL,
    RNDProsent INT NULL,
    Spesialisering NVARCHAR (255) NULL,
    FagenhetId INT NOT NULL,
    
    CONSTRAINT Fk_Table_Ansatt_Fagenhet FOREIGN KEY (FagenhetId) REFERENCES [dbo].Fagenhet (FagenhetId)
);

