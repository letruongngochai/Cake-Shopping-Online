

CREATE DATABASE ShoppingOnline
USE ShoppingOnline

create table PRODUCT
(
	PRODUCT_ID char(15), -- Ma SP
	PRODUCT_NAME varchar(100), -- Ten SP
	PRODUCT_TYPE varchar(15), -- Loai SP
	PRODUCT_PRICE int, -- Gia SP
	PRODUCT_SIZE_12 bit, -- Size 12cm?
	PRODUCT_SIZE_16 bit, -- Size 16cm?
	PRODUCT_INFO varchar(100), -- Thong tin SP
)

Drop table PRODUCT

select * from PRODUCT


insert into PRODUCT values('coffee1','Bac Xiu Coffee','Drinks', 50000, 0, 0, 'We use the best ingredients, from local fruits, French butter, Belgium chocolate.')
insert into PRODUCT values('coffee2','Black Coffee', 'Drinks',45000, 0, 0, 'We use the best ingredients, from local fruits, French butter, Belgium chocolate.')
insert into PRODUCT values('coffee3','Milk Coffee', 'Drinks',50000, 0, 0, 'We use the best ingredients, from local fruits, French butter, Belgium chocolate.')
insert into PRODUCT values('coffee4','Mango Caramel Latte', 'Drinks',70000, 0, 0, 'We use the best ingredients, from local fruits, French butter, Belgium chocolate.')

insert into PRODUCT values('juice1','Fresh Orange Juice', 'Drinks',45000, 0, 0, 'We use the best ingredients, from local fruits, French butter, Belgium chocolate.')
insert into PRODUCT values('juice2','Mixed Berry Coconut Juice', 'Drinks',55000, 0, 0, 'We use the best ingredients, from local fruits, French butter, Belgium chocolate.')
insert into PRODUCT values('juice3','Shisho Pomelo Juice', 'Drinks',60000, 0, 0, 'We use the best ingredients, from local fruits, French butter, Belgium chocolate.')

insert into PRODUCT values('milktea1','Salted Duck Egg Milk Tea', 'Drinks',65000, 0, 0, 'We use the best ingredients, from local fruits, French butter, Belgium chocolate.')
insert into PRODUCT values('milktea2','Sapodilla Chocolate Milk Tea', 'Drinks',55000, 0, 0, 'We use the best ingredients, from local fruits, French butter, Belgium chocolate.')
insert into PRODUCT values('milktea3','Vanilla Mango Milk Tea', 'Drinks',65000, 0, 0, 'We use the best ingredients, from local fruits, French butter, Belgium chocolate.')

insert into PRODUCT values('bakedgoods1','Cream Cheese & Raspberry Croissant', 'Baked Goods', 58000, 0, 0, 'Classic French croissant filled with cream cheese frosting and raspberry sauce.')
insert into PRODUCT values('bakedgoods2','Croissant', 'Baked Goods',39000, 0, 0, 'The classic French croissant, buttery and flaky layers.')
insert into PRODUCT values('bakedgoods3','Egg Tart', 'Baked Goods',49000, 0, 0, 'Puff pastry dough filled with light egg custard.')
insert into PRODUCT values('bakedgoods4','Raspberry Brownie', 'Baked Goods',58000, 0, 0, 'Gooey chocolate brownie, fresh raspberry, raspberry sauce, Himalayan salt Dalat raspberries.')
insert into PRODUCT values('bakedgoods5','Salted Duck Egg Curd Croissant', 'Baked Goods',58000, 0, 0, 'Classic French croissant filled with honey truffle salted duck egg curd and cream patissiere.')
insert into PRODUCT values('bakedgoods6','Say Cheese', 'Baked Goods',49000, 0, 0, 'Baked cheese tart with creme brulee top.')
insert into PRODUCT values('bakedgoods7','Sea Salted Cashew Brownie', 'Baked Goods',58000, 0, 0, 'Gooey chocolate brownie with chocolate chunks, cashew nuts, Bac Lieu salt.')

insert into PRODUCT values('tiramisu1','Classic Tiramisu', 'Cake', 390000, 1, 1, 'Layers of tiramisu cream, and espresso-soaked ladyfingers.')
insert into PRODUCT values('tiramisu2','Lava Tiramisu', 'Cake',390000, 1, 1, 'Espresso & rum-infused ladyfingers, soft tiramisu cream, lava Baileys cream cheese frosting.')
insert into PRODUCT values('tiramisu3','Matcha Tiramisu', 'Cake',490000, 1, 1, 'Raspberry & rosemary-infused lady fingers, soft tiramisu cream, matcha cream cheese frosting.')
insert into PRODUCT values('tiramisu4','Raspberry Tiramisu', 'Cake',490000, 1, 1, 'Raspberry-infused lady fingers, strawberries, whipped cream, fresh berries, rose & berry jelly.')

insert into PRODUCT values('chiffon1','Cheese Brulée Chiffon Cake', 'Cake',550000, 1, 1, 'Soft and spongy vanilla chiffon cake, salted cheese whipped cream, salted caramel sauce.')
insert into PRODUCT values('chiffon2','Chocolate Chiffon Cake', 'Cake',550000, 1, 1, 'Chocolate ganache, chocolate whipped cream frosting, mixed berry jam, chocolate macaron, strawberry.')
insert into PRODUCT values('chiffon3','Mango Chiffon Cake', 'Cake',550000, 1, 1, 'Mango sauce, whipped cream frosting, mango & chilli macaron, Dalat blackberry, Dalat lavender.')
insert into PRODUCT values('chiffon4','Sapodilla & Coffee Chiffon Cake', 'Cake',520000, 1, 1, 'Soft and spongy vanilla chiffon cake, sapodilla sauce, Vietnamese coffee whipped cream.')

insert into PRODUCT values('others1','Dog BDay Cake', 'Cake',490000, 1, 1, 'Handmade natural and healthy peanut butter birthday dog cake made with 100% natural ingredients.')
insert into PRODUCT values('others2','Caramel Mousse', 'Cake',490000, 1, 1, 'Caramel mousse, thin crunchy dark chocolate and caramel whipped cream.')
insert into PRODUCT values('others3','Umeshu Rose Mousse', 'Cake',590000, 1, 1, 'A plum wine mousse with plum jam, apricot wine sauce and rose infused genoise cake.')
insert into PRODUCT values('others4','Op La', 'Cake',450000, 1, 1, 'Layers of no-bake cheesecake, genoise, salted duck egg cream & curd.')
insert into PRODUCT values('others5','Op La 2', 'Cake',580000, 1, 1, 'Layers of no-bake cheesecake, genoise, salted duck egg cream & curd.')
insert into PRODUCT values('others6','Pina Colada', 'Cake',580000, 1, 1, 'Spiced rum pineapple compote, soft ladyfingers. Compote made with poached pineapple.')

insert into PRODUCT values('combo1','Combo Cheers', 'Combo',930000, 1, 1, '1 Cheese Brulee Chiffon Cake (Large) + Song Cai Gin 750ml (Gift) + Bday decorations')
insert into PRODUCT values('combo2','Combo Chill', 'Combo',750000, 1, 1, '1 Classic Tiramisu (Large) + Ceramic Op La Plate (Gift) + Bday decorations')
insert into PRODUCT values('combo3','Combo Crush', 'Combo',780000, 1, 1, '1 Op La (Small) + Earrings from TauTau Studio (Gift) + Bday decorations')
insert into PRODUCT values('combo4','Combo Home', 'Combo',955000, 1, 1, '1 Op La 2 (Large) + Bakes scented candle (Gift) + Bday decorations')
insert into PRODUCT values('combo5','Combo Joy', 'Combo',755000, 1, 1, '1 Chocolate Chiffon Cake (Large) + Bday decorations')

select * from PRODUCT where PRODUCT_ID like '" + "" + "%'

create table SHOPPINGPRODUCT
(
	[ID] [varchar](150) NULL,  
    [Name] [varchar](150) NULL,  
	[Size] [varchar](10) NULL,
	[Quantity] [int] NULL,  
    [Price] [int] NULL
)

drop table SHOPPINGPRODUCT
select * from SHOPPINGPRODUCT
truncate table SHOPPINGPRODUCT

