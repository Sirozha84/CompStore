SELECT equipments.ID,
       equipments.model,
       equipments.sn,
       equipments.[in],
       equipments.buy,
       equipments.buydate,
       equipments.comment,
       eqtypes.name || " " || vendors.name || " " || models.name AS modelText,
       users.f || " " || users.i || " " || users.o AS userText,
       buildings.name || ", " || rooms.name AS roomText,
       eqtypes.printer as printer
  FROM equipments
       LEFT JOIN
       models ON equipments.model = models.ID
       LEFT JOIN
       eqtypes ON models.eqtype = eqtypes.ID
       LEFT JOIN
       vendors ON models.vendor = vendors.ID
       LEFT JOIN
       (
           SELECT equipment,
                  user,
                  room,
                  max(date) 
             FROM moves
            GROUP BY equipment
       )
       m ON equipments.ID = m.equipment
       LEFT JOIN
       users ON m.user = users.ID
       LEFT JOIN
       rooms ON m.room = rooms.ID
       LEFT JOIN
       buildings ON rooms.building = buildings.ID;
