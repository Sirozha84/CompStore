SELECT rooms.id,
       rooms.filial,
       rooms.building,
       rooms.name,
       rooms.comment,
       filials.name || ", зд. " || buildings.name || ", пом. " || rooms.name AS buildingText
  FROM rooms
       LEFT JOIN
       filials ON rooms.filial = filials.ID
       LEFT JOIN
       buildings ON rooms.building = buildings.ID
 ORDER BY filials.name,
          buildings.name,
          rooms.name;
