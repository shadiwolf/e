// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using osu.Framework.Allocation;
using osu.Framework.Configuration;
using osu.Framework.Graphics.Containers;
using osu.Game.Rulesets.Osu.Objects;
using OpenTK;

namespace osu.Game.Rulesets.Osu.Edit.Blueprints
{
    /// <summary>
    /// A piece of a blueprint which responds to changes in the state of a <see cref="OsuHitObject"/>.
    /// </summary>
    public abstract class HitObjectPiece : CompositeDrawable
    {
        protected readonly IBindable<Vector2> PositionBindable = new Bindable<Vector2>();
        protected readonly IBindable<int> StackHeightBindable = new Bindable<int>();
        protected readonly IBindable<float> ScaleBindable = new Bindable<float>();

        private readonly OsuHitObject hitObject;

        protected HitObjectPiece(OsuHitObject hitObject)
        {
            this.hitObject = hitObject;
        }

        [BackgroundDependencyLoader]
        private void load()
        {
            PositionBindable.BindTo(hitObject.PositionBindable);
            StackHeightBindable.BindTo(hitObject.StackHeightBindable);
            ScaleBindable.BindTo(hitObject.ScaleBindable);
        }
    }
}
