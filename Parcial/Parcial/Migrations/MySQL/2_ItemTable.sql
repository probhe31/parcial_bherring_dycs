CREATE TABLE item(
  item_id BIGINT UNSIGNED NOT NULL AUTO_INCREMENT,
  item_name VARCHAR(50) NOT NULL,
  item_description VARCHAR(300) NOT NULL,  
  item_level INT UNSIGNED NOT NULL,      
  PRIMARY KEY(item_id)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;


INSERT INTO item(item_name, item_description, item_level) 
VALUES
('Pergamino de teletransporte', 'Te teletransporta a la estructura aliada objetivo.', 1),
('Anillo de basilius', ' Otorga regeneración de maná y armadura en un área de 900.', 1),
('Escudo robusto', 'Te teletransporta a la estructura aliada objetivo.', 2),
('Guantes de fuerza', '+3 Fuerza.', 2),
('Mano de midas', 'Mata a un objetivo no héroe a cambio de 200 de oro y 1.85x de experiencia.', 2),
('Máscara mórbida', ' Cura al atacante un porcentaje del daño de ataque infligido.', 2),
('Daga de traslación', 'Te teletransporta un máximo de 1200 unidades hasta el punto objetivo..', 2),
('Martillo de mithril', 'Un martillo forjado con puro mithril, otorga +24 Daño.', 3),
('Grebas del guardián', 'Uno de los muchos instrumentos sagrados construidos en honor a la Omnisciencia. ', 3),
('Coraza de asalto', 'Forjada en lo más recóndito de los confines abisales, esta malla infernal proporciona a un ejército una armadura y velocidad de ataque aumentadas.', 3),
('Guadaña de Vyse', 'La reliquia mejor custodiada en el culto a Vyse, es el arma más codiciada por los magos.', 4),
('Hoja Abisal', 'La hoja perdida del Comandante del Abismo, este filo atraviesa el alma de un enemigo.', 4),
('Reliquia Sagrada', 'Una antigua arma que suele cambiar el curso de la batalla.', 4);
