﻿using System.Collections.Generic;

namespace Swimming.Abstractions.Interfaces
{
    public interface ITrainingsSwimmersSwimStyleManager<TrainingsSwimmersSwimStyle>
    {
        IEnumerable<TrainingsSwimmersSwimStyle> GetView();
        TrainingsSwimmersSwimStyle GetViewTraining(int id);
    }
}
