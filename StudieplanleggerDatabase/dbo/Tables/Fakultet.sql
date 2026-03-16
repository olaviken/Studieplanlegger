CREATE TABLE [dbo].[Fakultet] (
    [Organisasjonsnummer] INT            NOT NULL,
    [Navn]                NVARCHAR (255) NOT NULL,
    [Leder]               NVARCHAR (255) NOT NULL,
    [Beskrivelse]         NVARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([Organisasjonsnummer] ASC)
);

