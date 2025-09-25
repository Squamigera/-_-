using Microsoft.VisualStudio.TestTools.UnitTesting;
using УП_Задание_4;

namespace Тестирование_4_задания
{
    [TestClass]
    public class UnitTests
    {
        private AuthService _authService;

        [TestInitialize]
        public void Setup()
        {
            _authService = new AuthService();
        }

        // ============ ПОЗИТИВНЫЕ ТЕСТЫ (3) ============

        [TestMethod]
        public void Authenticate_ValidManagerCredentials_ReturnsManagerUser()
        {
            // Act
            User user = _authService.Authenticate("manager", "manager123");

            // Assert
            Assert.IsNotNull(user);
            Assert.AreEqual("manager", user.Логин);
            Assert.AreEqual(UserRole.Менеджер, user.Роль);
        }

        [TestMethod]
        public void ParseUserRole_Role0_ReturnsAdmin()
        {
            // Act
            UserRole role = _authService.ParseUserRole(0);

            // Assert
            Assert.AreEqual(UserRole.Администратор, role);
        }

        [TestMethod]
        public void CalculateDiscount_Amount100000_Returns10()
        {
            // Act
            decimal discount = DiscountHelper.CalculateDiscount(100000m);

            // Assert
            Assert.AreEqual(10, discount);
        }

        // ============ НЕГАТИВНЫЕ ТЕСТЫ (3) ============

        [TestMethod]
        public void Authenticate_InvalidPassword_ReturnsNull()
        {
            // Act
            User user = _authService.Authenticate("admin", "wrongpassword");

            // Assert
            Assert.IsNull(user);
        }

        [TestMethod]
        public void ParseUserRole_InvalidRole_ReturnsManager()
        {
            // Act
            UserRole role = _authService.ParseUserRole(999);

            // Assert
            Assert.AreEqual(UserRole.Менеджер, role);
        }

        [TestMethod]
        public void CalculateDiscount_NegativeAmount_Returns0()
        {
            // Act
            decimal discount = DiscountHelper.CalculateDiscount(-100m);

            // Assert
            Assert.AreEqual(0, discount);
        }
    }
}