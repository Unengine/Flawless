using Flawless.Battle.Skill;
using System.Collections.Generic;

namespace Flawless.Battle
{
    public interface ICharacter
    {
        public CharacterStat Stat { get; }
        public List<SkillBase> Skills { get; }

        public int UseSkill(SkillBase skill, ICharacter target);
        public int GetDamage(int damage);
    }
}