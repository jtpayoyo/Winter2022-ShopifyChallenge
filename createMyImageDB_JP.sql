/* 
 * Title: createMyImageDB_JP.sql
 * Date: Sep 20, 2021
 * Author: Jeanne Payoyo
 * Description: Creates database MyImageDB for image repository for the
 *			    Winter 2022 Shopify Developer Intern Challenge Question
 */

USE master
GO

IF DB_ID('MyImageDB') IS NOT NULL
	DROP DATABASE MyImageDB
GO

CREATE DATABASE MyImageDB
GO

USE [MyImageDB]
GO

-- Create items table
CREATE TABLE [dbo].[Items](
	ItemId int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	ItemName varchar(50) NOT NULL,
	ItemDescription varchar(100) NOT NULL,
	ItemQuantity int NOT NULL,
	FactoryPrice money NOT NULL,
	FactoryDiscount money NOT NULL,
	ItemPrice money NOT NULL,
	ItemDiscount money NOT NULL,
	ImageId int NOT NULL
);

-- Create images table
CREATE TABLE [dbo].[Images](
	ImageId int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	ImageName varchar(40) NOT NULL,
	ImageFormat nvarchar(5) NOT NULL,
	ImageFile varbinary(max) NOT NULL
);

-- Add foreign key constraint
ALTER TABLE [dbo].[Items] WITH NOCHECK ADD CONSTRAINT [FK_Items_Images] FOREIGN KEY ([ImageId])
REFERENCES [dbo].[Images] ([ImageId])
GO

-- Add images
INSERT INTO [dbo].[Images] (ImageName, ImageFormat,ImageFile)
SELECT 'ChickWithSunhat','png',ImageFile
FROM OPENROWSET(BULK N'C:\ChicksWithHats\sunhat.png',SINGLE_BLOB)AS ImageSource(ImageFile);

INSERT INTO [dbo].[Images] (ImageName, ImageFormat,ImageFile)
SELECT 'ChickWithCrown','png',ImageFile
FROM OPENROWSET(BULK N'C:\ChicksWithHats\tiara.png',SINGLE_BLOB)AS ImageSource(ImageFile);

INSERT INTO [dbo].[Images] (ImageName, ImageFormat,ImageFile)
SELECT 'ChickWithCap','png',ImageFile
FROM OPENROWSET(BULK N'C:\ChicksWithHats\baseball.png',SINGLE_BLOB)AS ImageSource(ImageFile);

INSERT INTO [dbo].[Images] (ImageName, ImageFormat,ImageFile)
SELECT 'ChickWithWatermelon','png',ImageFile
FROM OPENROWSET(BULK N'C:\ChicksWithHats\watermelon.png',SINGLE_BLOB)AS ImageSource(ImageFile);

-- Add items
INSERT Items(ItemName, ItemDescription, ItemQuantity, FactoryPrice, FactoryDiscount, ItemPrice, ItemDiscount, ImageId) 
	values(N'Chick with Sunhat',N'A little chick wearing a sunhat in the breeze', 50, 8.00, 0.1, 15.00, 0.2, 1);
INSERT Items(ItemName, ItemDescription, ItemQuantity, FactoryPrice, FactoryDiscount, ItemPrice, ItemDiscount, ImageId) 
	values(N'Chick with Crown',N'A royal chick exuding a regal presence', 35, 12.00, 0.4, 20.00, 0.3, 2);
INSERT Items(ItemName, ItemDescription, ItemQuantity, FactoryPrice, FactoryDiscount, ItemPrice, ItemDiscount, ImageId) 
	values(N'Chick with Cap',N'A sporty chick ready to play ball', 20, 9.00, 0.3, 10.00, 0.1, 3);
INSERT Items(ItemName, ItemDescription, ItemQuantity, FactoryPrice, FactoryDiscount, ItemPrice, ItemDiscount, ImageId) 
	values(N'Chick with Watermelon',N'A summer chick who loves to eat fruit', 100, 10.00, 0.5, 11.00 , 0.4, 4);