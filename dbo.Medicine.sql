CREATE TABLE [dbo].[Medicine]
(
	[P_id] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [P_name] VARCHAR(50) NULL, 
    [P_price] VARCHAR(50) NULL, 
    [P_brand] VARCHAR(50) NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([P_id])
)
