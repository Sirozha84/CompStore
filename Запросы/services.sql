SELECT services.ID,
       services.equipment,
       services.date,
       services.work,
       services.consumable,
       services.counter,
       services.comment,
       eqtypes.name || " " || vendors.name || " " || models.name || " (" || equipments.sn || ")"
  FROM services
       LEFT JOIN
       equipments ON services.equipment = equipments.ID
       LEFT JOIN
       models ON equipments.model = models.ID
       LEFT JOIN
       eqtypes ON models.eqtype = eqtypes.ID
       LEFT JOIN
       vendors ON models.vendor = vendors.ID
 ORDER BY services.date