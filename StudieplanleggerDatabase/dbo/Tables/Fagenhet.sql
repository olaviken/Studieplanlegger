CREATE TABLE [dbo].[Fagenhet] (
    [FagenhetId]   INT            NOT NULL,
    [Fagenhetnavn] NVARCHAR (255) NOT NULL,
    [Leder]        NVARCHAR (255) NOT NULL,
    [Beskrivelse]  NVARCHAR (255) NOT NULL,
    [InstituttID]  INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([FagenhetId] ASC),
    FOREIGN KEY ([InstituttID]) REFERENCES [dbo].[Institutt] ([Id])
);

