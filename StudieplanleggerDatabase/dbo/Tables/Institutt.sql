CREATE TABLE [dbo].[Institutt] (
    [Id]          INT            NOT NULL,
    [Navn]        NVARCHAR (255) NOT NULL,
    [leder]       NVARCHAR (255) NOT NULL,
    [Beskrivelse] NVARCHAR (MAX) NULL,
    [FakultetId]  INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([FakultetId]) REFERENCES [dbo].[Fakultet] ([Organisasjonsnummer])
);

