
#include "clsLoginScreen.h"
#include "clsUser.h"
clsUser CurrentUser = clsUser::Find("");

int main(void)
{
	bool result = 1;
	while (result)
	{
		result = clsLoginScreen::ShowLoginScreen();
	}
	return 0;
}
