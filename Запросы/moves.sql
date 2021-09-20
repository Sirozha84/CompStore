SELECT moves.ID,
       moves.equipment,
       moves.user,
       moves.room,
       moves.date,
       moves.mol,
       moves.comment,
       eqtypes.name || " " || brands.name || " " || models.name AS equipmentText,
       users.f || " " || users.i || " " || users.o AS userText,
       buildings.name || ", " || rooms.name,
       mols.f || " " || mols.i || " " || mols.o AS molText
  FROM moves
       LEFT JOIN
       equipments ON moves.equipment = equipments.ID
       LEFT JOIN
       models ON equipments.model = models.ID
       LEFT JOIN
       eqtypes ON models.eqtype = eqtypes.ID
       LEFT JOIN
       brands ON models.brand = brands.ID
       LEFT JOIN
       users ON moves.user = users.ID
       LEFT JOIN
       rooms ON moves.room = rooms.ID
       LEFT JOIN
       buildings ON rooms.building = buildings.ID
       LEFT JOIN
       users mols ON moves.mol = mols.ID 
 ORDER BY moves.date;
