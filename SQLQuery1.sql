Create table [tblUser]
(
    [ID] [varchar](50) NOT NULL Primary key,
	[Account] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Realname] [varchar](50) NOT NULL,
	[Address] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[Role] [varchar](50) NULL
);

--Drop table [tblUser];

INSERT INTO [tblUser] VALUES 
('UN00','Test','Login','Password','manger', 'testE','testP','testA'),
('UN01', 'John Doe', 'john_admin', 'admin123', 'admin', 'john.doe@example.com', '+1 123-456-7890', '123 Main St, Anytown, USA'),
('UN02','Jane Smith', 'janemanag', 'manager456', 'manager', 'jane.smith@example.com', '+1 987-654-3210', '456 Elm Ave, Cityville, USA'),
('UN03', 'Michael Johnson', 'chef_mike', 'secretchef', 'chef', 'mike.johnson@example.com', '+1 555-123-4567', '789 Oak Rd, Culinarytown, USA'),
('UN04', 'Emily Brown', 'emily_customer', 'customer789', 'customer', 'emily.brown@example.com', '+1 234-567-8901', '101 Maple Ln, Shopper City, USA')
;

Create table Menu_item
(ItemID int NOT NULL PRIMARY KEY,
[Name] nvarchar(50),
Price float,
[Description] nvarchar(200),
Category nvarchar(10),
Callories int,
Ingridients nvarchar(300)
);
--Drop Table Menu_item;
INSERT INTO Menu_item (ItemID, [Name], Price, [Description], Category, Callories, Ingridients)
VALUES
    (201, 'Napkins', 1.20, 'Disposable napkins for cleaning hands and face', 'Supplies', NULL, NULL),
    (202, 'Plastic Cups', 2.00, 'Disposable plastic cups for beverages', 'Supplies', NULL, NULL),
    (203, 'Straws', NULL, 'Plastic straws for drinks', 'Supplies', NULL, NULL),
    (204, 'Stir Sticks', NULL, 'Wooden stir sticks for coffee and tea', 'Supplies', NULL, NULL),
    (205, 'Takeout Containers', 3.50, 'Disposable takeout containers for food', 'Supplies', NULL, NULL),
    (101, 'Cheeseburger', 8.99, 'Classic cheeseburger with beef patty and cheddar cheese', 'Burgers', 550, 'Chicken patty, cheddar cheese, lettuce, tomato, onion, pickles'),
    (102, 'Margherita Pizza', 12.49, 'Traditional pizza with tomato sauce, mozzarella, and basil', 'Pizza', 750, 'Pizza dough, tomato sauce, mozzarella cheese, fresh basil'),
    (103, 'Caesar Salad', 6.99, 'Classic Caesar salad with romaine lettuce and croutons', 'Salads', 350, 'Romaine lettuce, croutons, Caesar dressing, Parmesan cheese')
;
Select Ingridients from Menu_item where ItemID = 203;

CREATE TABLE [Reservation] (
    [reservationId]     INT          IDENTITY (1, 1) NOT NULL,
    [customerID]        [varchar](50)          NOT NULL,
    [reservationTypeID] INT          NOT NULL,
    [date]              VARCHAR (50) NOT NULL,
    [reservationStatus] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([reservationId] ASC),
    FOREIGN KEY ([reservationTypeID]) REFERENCES [dbo].[ReservationType] ([reservationTypeID]),
    FOREIGN KEY ([customerID]) REFERENCES [tblUser] ([ID])
);

CREATE TABLE [ReservationType] (
    [reservationTypeID]   INT          IDENTITY (1, 1) NOT NULL,
    [reservationTypeName] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([reservationTypeID] ASC)
);

--Insert into [ReservationType]([reservationTypeName]) Values ('type 2');
--Select * from [ReservationType];


--Colin`s tables

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblIngredient](
	[IngredientID] [varchar](50) NOT NULL,
	[Ingredient] [varchar](50) NULL,
	[Quantity] [int] NOT NULL,
	[Unit] [varchar](50) NULL,
	[Brand] [varchar](50) NULL,
	[Supplier] [varchar](50) NULL,
	[ItemID] [varchar](50) NOT NULL,
	[CreatedTime] [datetime] NULL,
	[Creator] [varchar](50) NULL,
	[ChangedTime] [datetime] NULL,
	[Editor] [varchar](50) NULL,
 CONSTRAINT [PK_tblIngredient] PRIMARY KEY CLUSTERED 
(
	[IngredientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblOrder]    Script Date: 6/9/2024 9:32:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblOrder](
	[OrderId] [varchar](50) NOT NULL,
	[TableNO] [varchar](50) NOT NULL,
	[CustomerName] [varchar](50) NOT NULL,
	[CreatedTime] [datetime] NULL,
	[OrderStatus] [varchar](50) NULL,
	[OrderCompletedTime] [datetime] NULL,
	[CuisineID] [varchar](50) NULL,
	[CuisineName] [varchar](50) NULL,
	[CuisineStatus] [varchar](50) NULL,
 CONSTRAINT [PK_tblOrder] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


--testing 
INSERT INTO tblUser (ID, Account, Password, Realname, Address, Phone, Role)
VALUES
('2', 'john_doe', 'password123', 'John Doe', '123 Main St', '555-1234', 'Manager'),
('3', 'jane_smith', 'password456', 'Jane Smith', '456 Elm St', '555-5678', 'Chef'),
('4', 'admin_user', 'admin_pass', 'Admin User', NULL, NULL, 'Manager');