CREATE TABLE [dbo].[Ansatt] (
    [Epost]            NVARCHAR (50)  NOT NULL,
    [Etternavn]        NVARCHAR (50)  NOT NULL,
    [Fornavn]          NVARCHAR (50)  NOT NULL,
    [Fodselsdato]      DATE           NOT NULL,
    [Stillingsprosent] INT            NOT NULL,
    [RNDProsent]       INT            NOT NULL,
    [Spesialisering]   NVARCHAR (255) NOT NULL,
    [Fagenhet]         INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Epost] ASC),
    FOREIGN KEY ([Fagenhet]) REFERENCES [dbo].[Fagenhet] ([FagenhetId])
);

