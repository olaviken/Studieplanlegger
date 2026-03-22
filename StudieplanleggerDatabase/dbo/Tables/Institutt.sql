CREATE TABLE [dbo].Institutt (
    Id INT NOT NULL Identity(1,1) Primary key,
    Navn NVARCHAR (255) NOT NULL,
    leder NVARCHAR (255) NOT NULL,
    Beskrivelse NVARCHAR (MAX) NULL,
    FakultetId INT NOT NULL,
    
    FOREIGN KEY (FakultetId) REFERENCES [dbo].Fakultet (Organisasjonsnummer)
);

