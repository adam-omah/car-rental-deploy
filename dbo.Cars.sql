CREATE TABLE [dbo].[Cars] (
    [Registration] VARCHAR (12) NOT NULL,
    [FuelType]     VARCHAR (30) NOT NULL,
    [CostPerDay]   REAL         NOT NULL,
    PRIMARY KEY CLUSTERED ([Registration] ASC),
    CHECK ([CostPerDay]>(0))
);

