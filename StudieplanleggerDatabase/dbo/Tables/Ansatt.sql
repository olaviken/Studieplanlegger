CREATE TABLE [dbo].Ansatt (
    Epost            NVARCHAR (50)  NOT NULL Primary Key,
    Etternavn          NVARCHAR (50)  NOT NULL,
    Fornavn          NVARCHAR (50)  NOT NULL,
    Fodselsdato      DATE           NOT NULL,
    Stillingprosent INT            NOT NULL,
    RNDProsent       INT            NOT NULL,
    Spesialisering   NVARCHAR (255) NOT NULL,
    FagenhetId         INT            NOT NULL,
    FOREIGN KEY (FagenhetId) REFERENCES [dbo].[Fagenhet] ([FagenhetId])
);

