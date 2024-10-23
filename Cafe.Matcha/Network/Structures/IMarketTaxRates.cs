﻿// Copyright (c) FFCafe. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.

namespace Cafe.Matcha.Network.Structures
{
    using System;

    /// <summary>
    /// An interface that represents the tax rates received by the client when interacting with a retainer vocate.
    /// </summary>
    public interface IMarketTaxRates
    {
        /// <summary>
        /// Gets the category of this ResultDialog packet.
        /// </summary>
        uint Category { get; }

        /// <summary>
        /// Gets the tax rate in Limsa Lominsa.
        /// </summary>
        uint LimsaLominsaTax { get; }

        /// <summary>
        /// Gets the tax rate in Gridania.
        /// </summary>
        uint GridaniaTax { get; }

        /// <summary>
        /// Gets the tax rate in Ul'dah.
        /// </summary>
        uint UldahTax { get; }

        /// <summary>
        /// Gets the tax rate in Ishgard.
        /// </summary>
        uint IshgardTax { get; }

        /// <summary>
        /// Gets the tax rate in Kugane.
        /// </summary>
        uint KuganeTax { get; }

        /// <summary>
        /// Gets the tax rate in the Crystarium.
        /// </summary>
        uint CrystariumTax { get; }

        /// <summary>
        /// Gets the tax rate in the Crystarium.
        /// </summary>
        uint SharlayanTax { get; }

        /// <summary>
        /// Gets the tax rate in Tuliyollal.
        /// </summary>
        uint TuliyollalTax { get; }

        /// <summary>
        /// Gets until when these values are valid.
        /// </summary>
        DateTime ValidUntil { get; }
    }
}
