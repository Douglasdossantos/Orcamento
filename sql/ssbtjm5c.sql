IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Clientes] (
    [Id] int NOT NULL IDENTITY,
    [Nome] varchar(200) NOT NULL,
    [Telefone] varchar(50) NOT NULL,
    CONSTRAINT [PK_Clientes] PRIMARY KEY ([Id])
);
 
GO

CREATE TABLE [Produtos] (
    [Id] int NOT NULL IDENTITY,
    [Nome] varchar(200) NOT NULL,
    [Preco] decimal(18,2) NOT NULL,
    CONSTRAINT [PK_Produtos] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Orcamentos] (
    [Id] int NOT NULL IDENTITY,
    [ClienteId] int NOT NULL,
    [Data] datetime NOT NULL,
    CONSTRAINT [PK_Orcamentos] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Orcamentos_Clientes_ClienteId] FOREIGN KEY ([ClienteId]) REFERENCES [Clientes] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [OrcamentoProdutos] (
    [Id] int NOT NULL IDENTITY,
    [OrcamentoId] int NOT NULL,
    [ProdutoId] int NOT NULL,
    CONSTRAINT [PK_OrcamentoProdutos] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_OrcamentoProdutos_Orcamentos_OrcamentoId] FOREIGN KEY ([OrcamentoId]) REFERENCES [Orcamentos] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_OrcamentoProdutos_Produtos_ProdutoId] FOREIGN KEY ([ProdutoId]) REFERENCES [Produtos] ([Id]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_OrcamentoProdutos_OrcamentoId] ON [OrcamentoProdutos] ([OrcamentoId]);

GO

CREATE INDEX [IX_OrcamentoProdutos_ProdutoId] ON [OrcamentoProdutos] ([ProdutoId]);

GO

CREATE INDEX [IX_Orcamentos_ClienteId] ON [Orcamentos] ([ClienteId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201214040443_inicial', N'3.1.10');

GO

