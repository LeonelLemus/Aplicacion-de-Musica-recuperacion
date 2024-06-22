CREATE DATABASE musicapp;

USE musicapp;

CREATE TABLE Usuarios (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    NombreUsuario VARCHAR(255) UNIQUE,
    Contrasena VARCHAR(255),
    email  VARCHAR(100)
);

CREATE TABLE Canciones (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Titulo VARCHAR(255),
    Artista VARCHAR(255),
    Album VARCHAR(255),
    ImagenUrl VARCHAR(255),
    AudioFilePath VARCHAR(255)
);

CREATE TABLE Playlists (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(255),
    UsuarioId INT,
    FOREIGN KEY (UsuarioId) REFERENCES Usuarios(Id)
);

CREATE TABLE PlaylistCanciones (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    PlaylistId INT,
    CancionId INT,
    FOREIGN KEY (PlaylistId) REFERENCES Playlists(Id),
    FOREIGN KEY (CancionId) REFERENCES Canciones(Id)
);
