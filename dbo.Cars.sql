CREATE TABLE [dbo].[Cars] (
    [Registration] VARCHAR (12) NOT NULL,
    [FuelType]     VARCHAR (30) NOT NULL DEFAULT 'Petrol',
	[Model] VARCHAR(100) NOT NULL DEFAULT 'Unkown',
    [NumberOfPassengers] TINYINT NOT NULL DEFAULT 1,
    [CostPerDay]   FLOAT         NOT NULL DEFAULT 50,
	[Status] NCHAR(1) NOT NULL DEFAULT 'A',
    [CarType] VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES CarTypes DEFAULT 'Hatchback',
    PRIMARY KEY CLUSTERED ([Registration] ASC),
    CHECK ([CostPerDay]>(0))
);

