CREATE TABLE [dbo].[Rentals]
(
	[Rental_ID] INT NOT NULL PRIMARY KEY IDENTITY,
	[StartDate] Date DEFAULT (getdate()) NOT NULL,
	[EndDate] Date DEFAULT (getdate()) NOT NULL,
	[PickUpDate] Date,
	[ReturnDate] Date,
	[Status] char default 'A' NOT NULL,
	[CarRegistration] varchar(12) FOREIGN KEY REFERENCES Cars NOT NULL,
	[Client_ID] INT FOREIGN KEY REFERENCES Clients not null,
)
