SELECT id, Spender, Betrag FROM `spenden` order by id desc limit 0,5;
SELECT SUM(Betrag) AS Summe FROM spenden;