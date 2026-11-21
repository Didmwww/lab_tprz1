using System;
using System.Collections.Generic;
using System.Linq;

namespace PowerShellTerminal.Lab2
{
    public class CommandHistoryRepository : IRepository<CommandHistory>
    {
        private readonly List<CommandHistory> _historyRecords = new List<CommandHistory>();
        private int _nextId = 1;

        public IEnumerable<CommandHistory> GetAll()
        {
            return _historyRecords;
        }

        public CommandHistory? GetById(int id)
        {
            return _historyRecords.FirstOrDefault(item => item.Id == id);
        }

        public void Add(CommandHistory entity)
        {
            entity.Id = _nextId++;
            if (entity.ExecutedAt == default)
            {
                entity.ExecutedAt = DateTime.Now;
            }
            _historyRecords.Add(entity);
        }

        public void Update(CommandHistory entity)
        {
            var existing = GetById(entity.Id);
            if (existing != null)
            {
                existing.CommandText = entity.CommandText;
                existing.ExecutedAt = entity.ExecutedAt;
                existing.IsSuccessful = entity.IsSuccessful;
            }
        }

        public void Delete(int id)
        {
            var existing = GetById(id);
            if (existing != null)
            {
                _historyRecords.Remove(existing);
            }
        }
    }
}
