SELECT cru, millesime
FROM VIN, PRODUCTEUR 
WHERE VIN.numprod=PRODUCTEUR.numprod
AND nomprod = 'Vallet'
AND cru = 'BEAUJOLAIS';