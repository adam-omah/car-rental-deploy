CREATE TABLE [dbo].[Clients] (
    [Client_Id]   INT          IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (50) NOT NULL,
    [Phone]       VARCHAR (15) NOT NULL,
    [Email]       VARCHAR (75) NOT NULL,
		[Password] VARCHAR(30) NOT NULL,
    [LicenceType] VARCHAR (50) DEFAULT 'Learner' NOT NULL,
    [Company]     VARCHAR (50) DEFAULT 'N' NOT NULL,
    PRIMARY KEY CLUSTERED ([Client_Id] ASC)
);

