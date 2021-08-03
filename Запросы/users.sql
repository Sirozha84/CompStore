SELECT users.ID,
       users.f,
       users.i,
       users.o,
       users.post,
       users.dep,
       users.room,
       users.emp,
       users.empdate,
       users.dis,
       users.disdate,
       users.comment,
       users.f || " " || users.i || " " || users.o AS nameText,
       posts.name AS postName,
       deps.name AS depName,
       filials.name || ", Р·Рґ. " || buildings.name || ", РїРѕРј. " || rooms.name AS roomText
  FROM users
       LEFT JOIN
       posts ON users.post = posts.ID
       LEFT JOIN
       deps ON users.dep = deps.ID
       LEFT JOIN
       rooms ON users.room = rooms.ID
       LEFT JOIN
       buildings ON rooms.building = buildings.ID
       LEFT JOIN
       filials ON buildings.filial = filials.ID
 WHERE users.type = 'u'
 ORDER BY users.f,
          users.i,
          users.o;
