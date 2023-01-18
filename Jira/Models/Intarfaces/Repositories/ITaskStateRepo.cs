﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jira.Models.Entities;

namespace Jira.Models.Intarfaces.Repositories
{
	public interface ITaskStateRepo : IIdRepo<TaskState>
	{
		Task AddTaskAsync(TaskJira taskJira, int taskStateId);
	}
}
