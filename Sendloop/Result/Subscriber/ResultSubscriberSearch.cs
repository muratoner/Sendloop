﻿using System.Collections.Generic;
using Sendloop.Model.Subscriber;

namespace Sendloop.Result.Subscriber {
    public class ResultSubscriberSearch : ResultBase {
        public List<SubscriberSearchResult> SearchResults { get; set; }
    }
}
