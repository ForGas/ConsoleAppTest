ALTER TABLE Bank_Clients
ADD CONSTRAINT [FK_Bank_Clients_To_Cities] FOREIGN KEY (CityId) REFERENCES Cities (Id);

ALTER TABLE Bank_Clients
ADD CONSTRAINT [FK_Bank_Clients_To_Countries] FOREIGN KEY (CountryId) REFERENCES Countries (Id);