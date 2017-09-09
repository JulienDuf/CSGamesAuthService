﻿using System;

namespace SecureTokenService.Config
{
    public static class ConfigManager
    {
        public static readonly TimeSpan TokenExpirationTime = TimeSpan.FromHours(2);
        
        // Mongo config
        public static string DatabaseConnectionString = Environment.Get("DB_CONNECTION_STRING") ?? "";
        public static string DatabaseName = Environment.Get("DB_NAME") ?? "";
        
        // Redis config
        public static string RedisConnectionString = Environment.Get("REDIS_CONNECTION_STRING") ?? "";
    }
}