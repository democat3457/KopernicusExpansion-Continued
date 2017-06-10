﻿using Kopernicus;
using LibNoise;
using System.Collections.Generic;

namespace KopernicusExpansion
{
    namespace ModularNoise
    {
        namespace Configuration
        {
            [RequireConfigType(ConfigType.Node)]
            public class DisplaceInput : NoiseLoader<LibNoise.Modifiers.DisplaceInput>
            {
                [PreApply]
                [ParserTarget("Source", nameSignificance = NameSignificance.Type, optional = false)]
                public NoiseLoader<IModule> sourceModule;

                [PreApply]
                [ParserTarget("DisplaceX", nameSignificance = NameSignificance.Type, optional = false)]
                public NoiseLoader<IModule> displaceXModule;

                [PreApply]
                [ParserTarget("DisplaceY", nameSignificance = NameSignificance.Type, optional = false)]
                public NoiseLoader<IModule> displaceYModule;

                [PreApply]
                [ParserTarget("DisplaceZ", nameSignificance = NameSignificance.Type, optional = false)]
                public NoiseLoader<IModule> displaceZModule;

                public override void Apply(ConfigNode node)
                {
                    noise = new LibNoise.Modifiers.DisplaceInput(sourceModule.noise, displaceXModule.noise, displaceYModule.noise, displaceZModule.noise);
                }
            }
        }
    }
}