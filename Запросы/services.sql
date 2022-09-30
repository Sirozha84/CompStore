SELECT services.ID,
       services.equipment,
       services.date,
       services.work,
       services.consumable,
       services.counter,
       services.comment,
       eqtypes.name || " " || vendors.name || " " || models.name || " (" || equipments.sn || ")",
       users.f || " " || users.i || " " || users.o AS userText,
       deps.name as depText
  FROM services
       LEFT JOIN
       equipments ON services.equipment = equipments.ID
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
       deps ON users.dep = deps.ID
 ORDER BY services.date