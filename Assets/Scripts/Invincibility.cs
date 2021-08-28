using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invincibility : PowerUpBase
{
	[SerializeField] Material _currentMat;
	[SerializeField] Material _powerMat;
	Player _player;

	protected override void PowerUp(Player player)
	{
		player.MaterialSwap(_powerMat);
	}

	protected override void PowerDown(Player player)
	{
		player.MaterialSwap(_currentMat);
	}

	private void Protection(Player player)
	{
		player.SetInvicibility();
	}
}
