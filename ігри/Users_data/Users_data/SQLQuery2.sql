SELECT 
    u.id,
    u.user_name,
    u.user_password,
    GROUP_CONCAT(a.achievement_name ORDER BY a.achievement_name ASC) AS user_achievements
FROM 
    users u
LEFT JOIN 
    user_achievements ua ON u.id = ua.user_id
LEFT JOIN 
    achievements a ON ua.achievement_id = a.id
GROUP BY 
    u.id, u.user_name, u.user_password;
