CREATE TABLE [dbo].[Book] (
    [Id]     INT         NOT NULL,
    [Nombre]  NVARCHAR(100) NOT NULL,
    [Usuario] NVARCHAR(100) NOT NULL,
    [Contraseña]  NVARCHAR(50)         NOT NULL,
    PRIMARY KEY CLUSTERED ([Id])
);

