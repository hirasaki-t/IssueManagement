import { Meta, Story } from "@storybook/react/types-6-0";
import HomePage from "../pages/HomePage";

export default {
    title: "pages/HomePage",
    components: HomePage,
} as Meta;

const Template: Story = () => <HomePage />;

export const Default = Template.bind({});