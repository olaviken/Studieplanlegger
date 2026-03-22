CREATE TABLE [dbo].Institutt (
    Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Navn NVARCHAR (255) NOT NULL,
    leder NVARCHAR (255) NOT NULL,
    Beskrivelse NVARCHAR (MAX) NULL,
    FakultetId INT NOT NULL,
    
    CONSTRAINT Fk_Table_Institutt_Fakultet FOREIGN KEY (FakultetId) REFERENCES [dbo].Fakultet (Organisasjonsnummer)
);

