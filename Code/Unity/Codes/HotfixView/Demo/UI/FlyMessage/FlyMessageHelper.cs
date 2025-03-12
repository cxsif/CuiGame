using UnityEngine;

namespace ET
{
    public static class FlyMessageHelper
    {
        public static string GetErrorCodeStr(int errorCode)
        {
            switch (errorCode)
            {
                case ErrorCode.ERR_NetWorkError:
                    return "网络错误,请稍后再试";
                case ErrorCode.ERR_AccountNameFormError:
                    return "登录账号格式错误";
                case ErrorCode.ERR_PasswordFormError:
                    return "登录密码格式错误";
                case ErrorCode.ERR_AccountInBlackListError:
                    return "账号处于黑名单中";
                case ErrorCode.ERR_LoginPasswordError:
                    return "登录密码错误";
                case ErrorCode.ERR_RequestRepeatedly:
                    return "请求频繁,稍后再试";
                case ErrorCode.ERR_RoleNameIsNull:
                    return "游戏角色名为空";
                case ErrorCode.ERR_RoleNameSame:
                    return "游戏角色名已被注册";
                case ErrorCode.ERR_RoleNotExist:
                    return "游戏角色名不存在";
                case ErrorCode.ERR_RequestSceneTypeError:
                    return "请求scene错误";
                default:
                    return "登录成功";
            }
        }

        public static void Show(Scene zoneScene,string content ="")
        {
            zoneScene.GetComponent<FlyMessageViewComponent>().SpawnFlyMessage(content, Vector3.zero).Coroutine();
        }

        public static void ShowErrorCode(Scene zoneScene, int errorCode = ErrorCode.ERR_Success)
        {
            string content = GetErrorCodeStr(errorCode);
            zoneScene.GetComponent<FlyMessageViewComponent>().SpawnFlyMessage(content, Vector3.zero).Coroutine();
        }
    }
}
