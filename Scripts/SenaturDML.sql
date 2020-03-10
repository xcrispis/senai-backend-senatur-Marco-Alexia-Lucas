USE Senatur_Manha

INSERT INTO TipoUsuario(Nome) VALUES ('Admin'), ('Usuario')

INSERT INTO Usuario(Email, Senha, IdTipoUsuario) VALUES ('admin@admin.com', 'admin', 1), ('cliente@cliente.com', 'cliente', 2)

INSERT INTO Cidades(NomeCidade) VALUES ('Salvador'), ('Bonito')

INSERT INTO Pacotes (NomePacote, Descricao, DataIda, DataVolta, Valor, IdCidade, Ativo) VALUES  ('SALVADOR - 5 DIAS / 4 DI�RIAS', '- O que n�o falta em Salvador s�o atra��es. 
Prova disso s�o as praias, os
museus e as constru��es seculares que d�o um charme mais que especial � regi�o. A
cidade, sin�nimo de alegria, tamb�m � conhecida pela efervesc�ncia cultural que a
credenciou como um dos destinos mais procurados por turistas brasileiros e
estrangeiros. O Pelourinho e o Elevador s�o alguns dos principais pontos de visita��o.', '06/08/2020', '10/08/2020', 854.00, 1, 1), 
('- RESORTS NA BAHIA - LITORAL NORTE - 5 DIAS / 4 DI�RIAS', ' caminhada pela orla e cal�ad�es,
passeios de bicicleta, pontos tur�sticos hist�ricos, intera��o com animais e at� baladas
est�o entre as atra��es da regi�o. Destacam-se as praias de Guarajuba, Imbassa�,
Praia do Forte e Costa do Sauipe', '14/05/2020', '18/05/2020', 1826.00, 1, 1),
('BONITO VIA CAMPO GRANDE - 1 PASSEIO - 5 DIAS / 4 DI�RIAS', ' Localizado no estado de Mato Grosso do
Sul e ao sul do Pantanal, Bonito possui centenas de cachoeiras, rios e lagos de �guas
cristalinas, al�m de cavernas inundadas, pared�es rochosos e uma infinidade de peixes.
Os aventureiros costumam render-se facilmente a esse destino regado por trilhas
ecol�gicas, passeios de bote e descidas de rapel pelas in�meras quedas d�gua da
regi�o.', '28/03/2020', '01/04/2020', 1004.00, 2, 1)