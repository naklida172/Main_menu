Create table [tblUser]
(
    [ID] [varchar](50) NOT NULL,
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