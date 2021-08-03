SELECT buildings.ID,
       buildings.filial,
       buildings.name,
       buildings.comment,
       filials.name AS filialText
  FROM buildings
       LEFT JOIN
       filials ON buildings.filial = filials.ID
 ORDER BY filials.name,
          buildings.name;
